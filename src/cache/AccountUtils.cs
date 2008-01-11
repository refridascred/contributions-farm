using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Synced,
            Failed,
            Ready,
            Idle,
        }
    }
}
