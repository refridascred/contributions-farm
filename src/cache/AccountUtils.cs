using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items)
        {
            long result = 2;
            foreach (long item in items)
            {
                result = ((result - (result * 4)) % 255) + item;
            }
            return result;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > rate)
            {
                bias2 = (bias2 + rate) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (bias2 - bias2)) + (double)(long)i;
            }
            return bias2 + rate;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "primary-v2";
        public const long DefaultEditor = 4546;
        public const long BurstEditor = 4686;
        public const long BurstSpan = 4618;
        public const long MinBudget = 3240;
    }
}
