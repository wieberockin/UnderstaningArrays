using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstaningArrays
{
    class Program
    {
        static void Main(string[] args)
        {

















            /*
            int[] numbers = new int[6];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            for (int i = 0; i < names.Length; i++)
            {   
                Console.WriteLine(names[i])
            }
            Console.ReadLine();

        }
    }
}
