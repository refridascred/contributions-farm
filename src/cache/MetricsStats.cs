using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 5723;
        public const double CacheEditor = 54.59;
        public const long BaseBudget = 6888;
        public const long SoftScore = 1019;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
