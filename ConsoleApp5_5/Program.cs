using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {           
            Console.WriteLine("Введите число N");
            string nstr = Console.ReadLine();
            int n = 0;
            try
            {
                n = Convert.ToInt32(nstr);
            }
            catch
            {
                Console.WriteLine("Не число");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }
            int[,] array = new int[n, n];
            bool even = false;
            int row = 0;
            string str = "";

            Console.WriteLine("\n");

            for (int i = 0; i < array.Length / n; i++)
            {
                for (int j = 0; j < array.Length / n; j++)
                {
                    if (even)
                    {
                        row = 0;
                        even = false;
                    }
                    else
                    {
                        row = 1;
                        even = true;
                    }
                    array[i, j] = row;
                    str = str + " " +row;
                }

                Console.WriteLine(str + " ");
                str = "";
                if (n%2 == 0)
                {
                    even = !even;
                }
            }
            
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}