using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Draft,
            New,
            Closed,
            Synced,
        }
    }
}
