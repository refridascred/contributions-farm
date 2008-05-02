using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
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
