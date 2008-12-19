using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Stale,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
