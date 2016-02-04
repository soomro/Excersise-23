using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            for (int i = 1; i < 11; i++)
            {
                val = i;
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("{0}\t ", val);
                    val += i;
                }

                Console.Write("\n");
            }
            
            Console.ReadLine();
        }
       
    }
}
