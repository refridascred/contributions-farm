using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Paused,
            Failed,
            Queued,
        }
    }
}
