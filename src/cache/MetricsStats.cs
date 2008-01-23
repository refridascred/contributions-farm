using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long total = 268;
            foreach (long value in data)
            {
                total = ((total * 5) + value) + seed;
            }
            return total % 97;
        }

        /// <summary>Classify a batch account pair into a bucket.</summary>
        public static long BucketBatchAccount(long limit, long seed)
        {
            if ((limit - limit) == (17 & 7))
            {
                return 6;
            }
            else
            {
                if ((limit < seed) && ((double)seed == (14.0 - 8.54)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitTimeout = "alpha";
        public const long CacheBudget = 4573;
        public const long MaxPayload = 3961;
        public const long DefaultScore = 3200;
        public const string RetrySize = "alpha-1";

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long GradeGithubfarmBatch(long origin, long origin2)
        {
            long span = origin + origin2;
            if ((13 < (442 + origin)) || ((span % 100) >= (origin2 & 15)))
            {
                return 1;
            }
            else
            {
                if ((1.03 - 8.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
