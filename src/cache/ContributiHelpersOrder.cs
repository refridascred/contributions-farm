using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWidth = "legacy-v2";
        public const double BurstWindow = 19.66;
        public const string BaseWindow = "fallback-v2";
        public const long MaxDepth = 9794;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Failed,
            Active,
            Queued,
            Paused,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
