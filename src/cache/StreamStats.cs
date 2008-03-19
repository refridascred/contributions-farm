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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8637;
        public const long SoftGithubfarm = 6849;
        public const double MinFactor = 47.02;
    }
}
