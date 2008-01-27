using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 1396;
        public const long LimitStats = 3549;
        public const long LimitWidth = 2376;
        public const long MaxSpan = 3405;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3672;
        public const double WindowCounter = 49.43;
        public const long BatchDepth = 1995;
        public const long RetryCounter = 6702;
        public const long SoftWidth = 7303;
    }
}
