using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x:");
            String x = Console.ReadLine();
            int xInt = Convert.ToInt32(x); // Int32.Parse(x);
            Console.WriteLine("x = " + sum(xInt));

            Console.Read();
        }
       static int sum(int x2)
        {
            return x2 * 2;
        }
    }
}
