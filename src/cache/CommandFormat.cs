using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchSize = 97.35;
        public const double BurstMetric = 0.25;
        public const long CacheMetric = 6311;
        public const long BatchMetric = 9666;
        public const string SoftMetric = "strict-edge";

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Paused,
            Done,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
