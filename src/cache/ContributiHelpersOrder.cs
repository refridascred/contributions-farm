using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            New,
            Draft,
            Failed,
            Stale,
        }
    }
}
