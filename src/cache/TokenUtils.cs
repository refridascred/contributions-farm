using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Failed,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Paused,
            Closed,
            Pending,
            Queued,
        }
    }
}
