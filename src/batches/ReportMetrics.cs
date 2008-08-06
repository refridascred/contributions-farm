using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseBudget = 2968;
        public const long WindowAlready = 1155;
        public const long BaseAlready = 5336;
        public const double RetryAlready = 6.95;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7036;
        public const long HardRatio = 9497;
        public const long BatchSize = 1880;
    }
}
