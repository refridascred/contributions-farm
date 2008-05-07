using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Active,
            Done,
            Queued,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Idle,
            Ready,
            Stale,
            Closed,
        }
    }
}
