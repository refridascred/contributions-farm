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

        /// <summary>Roll a profile counter counter forward.</summary>
        public static long RollProfileCounter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
