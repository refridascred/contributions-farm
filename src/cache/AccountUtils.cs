using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double scale, double bias)
        {
            double rate = scale - (double)42;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (scale - 19.0)) + (double)(long)i) + bias;
            }
            return rate + (double)64;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 8057;
        public const string DefaultSupport = "stable-1";
        public const long BaseSupport = 6480;

        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool ValidateAccountStreamRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
