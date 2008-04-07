using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseWidth = 60.19;
        public const long BatchSession = 722;
        public const double MaxInterval = 48.96;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Done,
            New,
            Stale,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Locked,
            Stale,
            Closed,
        }
    }
}
