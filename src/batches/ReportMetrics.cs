using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 935;
        public const long HardCommits = 6364;
        public const string WindowInterval = "stable";
        public const string DefaultCommits = "standard-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSpan = 2972;
        public const double BurstWindow = 54.86;
        public const string StepSize = "legacy-edge";
        public const long LimitBudget = 8116;
        public const double LimitWindow = 54.95;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8701;
        public const long BatchQueue = 1149;
        public const double CacheQueue = 9.45;
        public const long DefaultScore = 9691;
    }
}
