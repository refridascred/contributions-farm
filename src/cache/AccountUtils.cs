using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3784;
        public const long MaxSpan = 8073;
        public const long RetryCount = 2903;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
