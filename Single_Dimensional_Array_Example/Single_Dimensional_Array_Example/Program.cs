using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; //creating an array
            arr[0] = 10; //initializing array
            arr[2] = 20;
            arr[4] = 30;

            //Traversing array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}