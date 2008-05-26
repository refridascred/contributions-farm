using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }
    }
}
