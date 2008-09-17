using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 1505;
        public const double IdleSession = 76.83;
        public const double BurstBudget = 69.57;
        public const string SoftSession = "strict-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 1761;
        public const long SoftGraph = 1745;
        public const long BaseGraph = 6662;
        public const double RetrySize = 18.83;
        public const long RetryRatio = 8506;
    }
}
