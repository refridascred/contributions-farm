using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8296;
        public const string MaxFactor = "stable-v2";
        public const string DefaultOrder = "alpha-edge";
        public const long RetryOrder = 5600;
        public const long BurstOrder = 7918;
    }
}
