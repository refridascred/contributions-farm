using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Pending,
            New,
            Synced,
            Failed,
        }
    }
}
