using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "fallback-v2";
        public const long BurstWidth = 4714;
        public const double RetryInterval = 93.04;
        public const long MaxWindow = 3385;
        public const long StepDepth = 9594;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3301;
        public const string BatchDepth = "cached-edge";
        public const long SoftBuffer = 8349;
        public const long MaxFactor = 6839;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long StepToken = 5307;
        public const double RetryToken = 17.62;

        /// <summary>Count the queue metrics entries that pass the check.</summary>
        public static long TallyQueueMetricsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum * 4) <= (seen + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
