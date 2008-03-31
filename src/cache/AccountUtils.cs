using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Pending,
            Retry,
            Synced,
            Done,
        }
    }
}
