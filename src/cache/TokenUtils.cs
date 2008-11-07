using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 199;
        public const long SoftFormat = 9979;
        public const long BaseFormat = 5378;
        public const string LimitFormat = "cached-v2";
        public const double BaseSize = 42.46;

        /// <summary>Iterate the contributi farm series from a seed.</summary>
        public static long RollContributiFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (sum % 3)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
