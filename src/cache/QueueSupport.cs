using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
