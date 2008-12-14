using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Locked,
            Closed,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}
