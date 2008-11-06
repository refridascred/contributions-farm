using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Locked,
            Failed,
        }
    }
}
