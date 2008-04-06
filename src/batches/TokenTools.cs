using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 5480;
        public const double RetryCount = 6.43;
        public const long RetryOrder = 441;
        public const long MaxOrder = 8178;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
