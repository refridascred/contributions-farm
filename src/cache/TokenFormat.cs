using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinBudget = 4161;
        public const long BatchLevel = 8438;
        public const double WindowLayout = 93.31;
        public const long BaseLevel = 575;
        public const long LimitSpan = 4093;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 2004;
        public const double BaseWindow = 26.7;
        public const double HardBudget = 4.94;
        public const long WindowBudget = 9413;
    }
}
