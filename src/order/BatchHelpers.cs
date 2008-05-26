using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Done,
            Synced,
            Paused,
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
