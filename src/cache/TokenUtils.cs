using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long origin)
        {
            if ((63 * 2) < (target % 64))
            {
                return 8;
            }
            else
            {
                if (((7.0 / 8.0) > (double)origin) || (target < (190 & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) > 54)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count <= (sample * 4)) && ((2.0 / 6.0) <= (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
