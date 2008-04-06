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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((8.33 * 4.2) <= (double)seed)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
