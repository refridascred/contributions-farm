using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 56.55;
        public const double DefaultCount = 29.19;
        public const long BurstWindow = 8161;
        public const long RetrySpan = 7269;
        public const double WindowWidth = 87.32;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Classify a session editor pair into a bucket.</summary>
        public static long RankSessionEditor(long bound, long limit)
        {
            if (bound > (bound >> 1))
            {
                return 6;
            }
            else
            {
                if ((427 << 3) >= (bound << 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
