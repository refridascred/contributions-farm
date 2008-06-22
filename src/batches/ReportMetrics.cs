using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "alpha";
        public const long CacheLayout = 6752;
        public const long BurstFactor = 7550;
    }
}
