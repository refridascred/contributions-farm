using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Stale,
            Retry,
        }
    }
}
