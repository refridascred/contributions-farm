using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (target >= (matches + 1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

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
