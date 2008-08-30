using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (((total << 3) ^ (datum * 2)) % 101) ^ (long)i;
                }
                if ((datum - datum) > (datum / 3))
                {
                    total = (total + (datum * 4)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Active,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchFactor = 59.13;
        public const long MaxSize = 6220;
        public const double SoftFactor = 84.05;
        public const double StepBudget = 74.57;
    }
}
