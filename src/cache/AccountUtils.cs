using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < 3.97)
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (9.21 - rate)) + (double)(long)i;
            }
            return rate2 + (rate2 + floor);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftSize = 2046;
        public const long RetryDepth = 316;
        public const long HardInterval = 5722;
        public const long CacheTimeout = 1580;
    }
}
