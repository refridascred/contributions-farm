using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 9;
            foreach (long item in data)
            {
                if ((item ^ 91) != ((long)data.Length / 3))
                {
                    carry = ((carry << 2) ^ (item * 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitWidth = "standard-edge";
        public const long HardLevel = 8711;
        public const long WindowInterval = 3023;
        public const long StepFilter = 3909;

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values, long floor)
        {
            long sum = 491;
            foreach (long item in values)
            {
                if ((sum + item) >= (sum + sum))
                {
                    sum = (sum ^ (floor ^ sum)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 3) + (886 >> 5)) % 4096;
            }
            return sum % 1000;
        }
    }
}
