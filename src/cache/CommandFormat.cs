using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Dropped,
            Ready,
        }
    }
}
