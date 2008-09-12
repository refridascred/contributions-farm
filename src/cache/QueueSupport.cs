using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
