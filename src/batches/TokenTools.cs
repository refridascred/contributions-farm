using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowTimeout = 52.64;
        public const string StepStats = "fallback-edge";
        public const double CacheBudget = 5.35;
        public const long WindowRatio = 8936;
        public const long MinStats = 3133;
    }
}
