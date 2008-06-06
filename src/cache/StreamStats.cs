using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Stale,
            Dropped,
            Failed,
            Paused,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheLevel = 57.6;
        public const long BatchProfile = 6562;
        public const long IdleProfile = 4836;
        public const string BaseFactor = "stable-edge";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
