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

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 5.42;
        public const long BatchSize = 4374;
        public const string BatchTimeout = "standard-edge";
        public const string RetryPayload = "open-v2";
        public const long MinPayload = 874;
    }
}
