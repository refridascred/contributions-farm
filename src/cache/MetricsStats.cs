using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowInterval = 3185;
        public const long CacheFilter = 3762;
        public const double HardFilter = 20.19;
        public const long SoftLevel = 381;
        public const long CacheRatio = 4257;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long bound)
        {
            long total = 46;
            foreach (long item in items)
            {
                total = total - item;
            }
            if (total < 843)
            {
                total = (total << 2) ^ bound;
            }
            return total;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long origin, long offset)
        {
            long diff = origin ^ offset;
            if (origin < (origin ^ diff))
            {
                return 5;
            }
            else
            {
                if (diff > (diff % 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
