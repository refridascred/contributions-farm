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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
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
