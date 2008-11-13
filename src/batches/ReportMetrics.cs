using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((345 + hits) < hits)
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8402;
        public const double StepNotes = 67.29;
        public const long BaseInterval = 347;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "latest-v2";
        public const string HardInterval = "alpha-v2";
        public const long LimitBudget = 6490;
        public const double MaxSpan = 80.87;
    }
}
