using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8807;
        public const long BurstEditor = 2090;
        public const string IdleEditor = "standard-edge";

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
