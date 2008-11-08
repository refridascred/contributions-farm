using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Done,
            Ready,
            Synced,
            Draft,
        }
    }
}
