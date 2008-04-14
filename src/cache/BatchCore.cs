using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Closed,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Dropped,
            Retry,
            Draft,
        }
    }
}
