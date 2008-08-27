using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Queued,
            Pending,
            Paused,
        }
    }
}
