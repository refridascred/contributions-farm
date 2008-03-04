using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 87.14;
        public const double HardOrder = 37.66;
        public const string DefaultFactor = "open-1";
        public const long LimitTimeout = 6659;
        public const string HardSize = "fallback-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
