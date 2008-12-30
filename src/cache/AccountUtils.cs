using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Draft,
            Stale,
            Failed,
            Dropped,
        }
    }
}
