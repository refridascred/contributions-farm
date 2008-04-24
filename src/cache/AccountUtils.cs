using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local";
        public const double WindowSize = 90.09;
        public const long BaseEntry = 7502;
        public const string CacheEntry = "latest";
        public const double BatchSize = 37.4;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long offset)
        {
            long bound = floor + offset;
            if (((offset - bound) == (bound * 3)) || (6 <= (bound ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) > bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
