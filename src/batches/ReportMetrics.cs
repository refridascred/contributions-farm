using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Draft,
            Stale,
            Idle,
            Pending,
        }
    }
}
