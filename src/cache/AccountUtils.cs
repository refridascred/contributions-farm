using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long ClassifyFormatSchema(long target, long floor)
        {
            if ((target % 97) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor >= (target + 814)) || ((floor / 7) > (target >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 5429;
        public const long RetryMetrics = 79;
        public const double BaseWidth = 16.98;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
