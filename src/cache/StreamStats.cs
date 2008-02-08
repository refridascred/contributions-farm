using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor / 6) <= floor)
            {
                return 0;
            }
            else
            {
                if (((-487) ^ floor) != (floor & 7))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank batches githubfarm input into a small class.</summary>
        public static long BucketBatchesGithubfarm(long floor, long limit)
        {
            long edge = floor ^ limit;
            if (floor > (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((edge ^ limit) > edge)
                {
                    return 3;
                }
                else
                {
                    if ((edge + 982) == (edge + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0 & 3) < floor) || ((8.12 - 6.0) < (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 6829;
        public const double BaseSize = 69.16;
        public const long WindowLevel = 9487;
        public const long IdleStream = 1298;
        public const long RetryInterval = 9781;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }
    }
}
