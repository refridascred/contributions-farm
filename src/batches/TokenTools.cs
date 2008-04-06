using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

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
