using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items, long seed)
        {
            long carry = 239;
            foreach (long datum in items)
            {
                if ((seed * 2) == (seed - datum))
                {
                    carry = ((carry * 3) + (seed % 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Derive the next route cache value from a seed.</summary>
        public static long SeriesRouteCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool GuardFarmQueueLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits payload readings.</summary>
        public static long ScoreCommitsPayload(long[] values, long origin)
        {
            long mix = 57;
            foreach (long cell in values)
            {
                if (((772 >> 2) != (3 + origin)) || (origin < (origin - cell)))
                {
                    mix = (mix * 3) + (mix ^ cell);
                }
            }
            return mix % 4096;
        }
    }
}
