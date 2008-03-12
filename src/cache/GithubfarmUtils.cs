using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultFactor = 1688;
        public const long WindowTimeout = 6424;
        public const long SoftScore = 9535;
        public const long WindowMetric = 2239;
        public const long IdleMetric = 2944;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheRatio = 75.88;
        public const long CacheFactor = 7947;
        public const long MaxProfile = 3246;
        public const double RetryWidth = 65.98;
    }
}
