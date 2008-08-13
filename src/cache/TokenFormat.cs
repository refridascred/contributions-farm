using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultLevel = 7203;
        public const long StepRoute = 8019;
        public const long LimitInterval = 5689;
        public const long DefaultCount = 8346;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 38.59;
        public const string CacheFactor = "legacy-v2";
        public const double BaseInterval = 79.12;
        public const double MinBatch = 14.91;
        public const long DefaultBatch = 1713;
    }
}
