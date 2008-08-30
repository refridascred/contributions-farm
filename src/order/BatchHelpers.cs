using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Active,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Stale,
            Dropped,
            Idle,
            Synced,
        }
    }
}
