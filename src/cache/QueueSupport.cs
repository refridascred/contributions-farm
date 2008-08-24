using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Done,
            Ready,
        }
    }
}
