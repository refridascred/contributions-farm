using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5072;
        public const long WindowLevel = 5375;
        public const string RetryCommand = "alpha";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Queued,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
