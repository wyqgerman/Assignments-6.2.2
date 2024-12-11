namespace Assignments_6._2._2
{
    internal class Program
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            int prefix = 1;
            for (int i = 0; i < n; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int suffix = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= nums[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = ProductExceptSelf(nums1);
            Console.WriteLine("Input: " + string.Join(", ", nums1));
            Console.WriteLine("Output: " + string.Join(", ", result1));

            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = ProductExceptSelf(nums2);
            Console.WriteLine("Input: " + string.Join(", ", nums2));
            Console.WriteLine("Output: " + string.Join(", ", result2));
        }
    }
}
