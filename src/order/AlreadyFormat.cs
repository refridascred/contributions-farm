using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the cache context entries that pass the check.</summary>
        public static long MeasureCacheContextOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((origin + 655) > (origin - origin)) || (((8 & 1) == (seen - item)) && ((origin >> 3) <= origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long carry = 586;
            foreach (long entry in data)
            {
                if ((8.25 * 2.9) == (double)carry)
                {
                    carry = (((carry << 3) ^ carry) + entry) - seed;
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8129;
        public const double IdleBudget = 27.94;
        public const string CacheFarm = "cached-edge";
        public const string MaxLevel = "latest-v2";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long acc = 88;
            foreach (long sample in series)
            {
                acc = (acc << 3) ^ (745 - sample);
                if (!((8.9 - 5.0) == (double)origin))
                {
                    acc = (acc - (sample & 15)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
