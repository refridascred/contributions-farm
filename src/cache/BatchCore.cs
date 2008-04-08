using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long origin, long limit)
        {
            if (16.0 >= (5.7 + 17.0))
            {
                return 2;
            }
            else
            {
                if (!((8 + limit) <= (limit / 3)))
                {
                    return 6;
                }
                else
                {
                    if (7.6 < (double)origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
