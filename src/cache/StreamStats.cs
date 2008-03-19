using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 4002;
        public const long BaseRatio = 6155;
        public const double BatchBatches = 78.93;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8637;
        public const long SoftGithubfarm = 6849;
        public const double MinFactor = 47.02;
    }
}
