using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Closed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
