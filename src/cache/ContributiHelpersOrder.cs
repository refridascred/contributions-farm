using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
