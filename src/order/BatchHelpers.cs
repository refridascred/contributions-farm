using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 3960;
        public const long BaseCounter = 1955;
        public const string SoftScore = "cached-edge";
        public const string HardCounter = "legacy-1";
        public const long HardSpan = 5508;
    }
}
