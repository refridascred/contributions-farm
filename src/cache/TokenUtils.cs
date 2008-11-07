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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 1.41;
        public const long DefaultFactor = 4492;
        public const long WindowContributi = 9816;

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
