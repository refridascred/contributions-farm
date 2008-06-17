using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultTimeout = 61.74;
        public const string HardBatch = "stable-edge";
        public const long BaseBatch = 8825;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Active,
            Locked,
        }
    }
}
