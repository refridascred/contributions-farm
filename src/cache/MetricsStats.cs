using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long anchor = 10;
            foreach (long reading in series)
            {
                if ((offset % 10) >= anchor)
                {
                    anchor = (anchor << 2) ^ (reading * 2);
                }
            }
            if (anchor < 313)
            {
                anchor = (anchor << 2) ^ (951 * 4);
            }
            return anchor % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 17.51;
        public const long CacheSize = 8220;
        public const long IdleBuffer = 8766;
        public const long CacheTimeout = 50;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            New,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6862;
        public const string CacheSpan = "primary-edge";
        public const long MinDepth = 6195;
        public const string IdleGithubfarm = "latest-1";

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
