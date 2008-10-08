using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 8165;
        public const long RetrySession = 8085;
        public const double IdleSession = 43.2;
        public const long BaseInterval = 276;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLevel = 7800;
        public const long MaxWidth = 9315;
        public const double HardSpan = 36.99;
    }
}
