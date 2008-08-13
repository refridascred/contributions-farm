using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 64.24;
        public const long BaseCache = 7965;
        public const string LimitCache = "staging-v2";
        public const double IdleTimeout = 87.57;
        public const double LimitSize = 74.11;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long seed)
        {
            long sum = 358;
            foreach (long item in readings)
            {
                if ((1 + seed) >= (sum << 1))
                {
                    sum = ((sum * 3) + (seed - 1)) - item;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstDepth = "staging-1";
        public const long MinWindow = 3520;
        public const double RetryWindow = 14.54;
    }
}
