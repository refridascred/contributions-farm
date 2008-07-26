using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Ready,
            Failed,
            Stale,
        }

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
