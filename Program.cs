using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 3, 2, 2, 3 };
            int[] arr = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int num = 2;

            int len= RemoveElement(arr, num);
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
       
        public static int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            for (int i = 0; i < len; i++)
            {
                if(nums[i]==val)
                {
                    for (int j = i; j < len - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    len--;
                    i--;
                }
            }
            return len;
        }
    }

}
