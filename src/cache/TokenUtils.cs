using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            New,
            Synced,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 931;
        public const long DefaultSize = 2018;
        public const long HardMetrics = 6561;
        public const double RetryFactor = 48.36;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
