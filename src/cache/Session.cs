using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-edge";
        public const double CacheStream = 76.31;
        public const long RetryWidth = 7369;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)limit > (6.5 * 4.61))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                if (((sample + sample) == (78 - sample)) && ((5.0 + 1.1) != (double)(long)items.Length))
                {
                    acc = ((acc * 2) + (sample + sample)) % 255;
                }
            }
            return acc;
        }
    }
}
