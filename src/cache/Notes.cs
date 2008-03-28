using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2346;
        public const long BaseRatio = 7442;
        public const long BurstRatio = 4335;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)datum >= 2.5))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Paused,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            if ((3.29 * 6.3) <= (double)origin2)
            {
                return 8;
            }
            else
            {
                if ((5.07 <= (double)origin2) || ((origin + origin) < (origin2 + 24)))
                {
                    return 3;
                }
                else
                {
                    if (((13.0 - 8.5) >= 4.41) || ((origin << 1) != (23 << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin / 5) >= origin2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
