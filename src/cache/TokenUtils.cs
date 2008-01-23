using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleCount = 3125;
        public const long CacheSize = 8568;
        public const string DefaultInterval = "primary";
        public const long CacheTimeout = 887;
        public const long BurstCount = 7257;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 1;
            foreach (long item in items)
            {
                if ((double)sum == (double)item)
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
            }
            return sum;
        }
    }
}
