using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Active,
            Done,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Ready,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
