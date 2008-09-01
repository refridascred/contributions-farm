using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (seed / 6)) % 101;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 - seed) <= seed2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 > (3.34 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinLevel = 2349;
        public const string DefaultBatch = "fallback-1";
        public const long LimitBatch = 1900;
        public const string BaseFactor = "fallback";
        public const long BatchLevel = 2036;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 31.96;
        public const long CacheGithubfarm = 2453;
        public const long BaseGithubfarm = 6631;
        public const string IdleGithubfarm = "staging-1";
    }
}
