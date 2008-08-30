using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            New,
            Idle,
            Failed,
            Active,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Dropped,
            Idle,
            Synced,
            Retry,
        }
    }
}
