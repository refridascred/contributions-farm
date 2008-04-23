using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(offset < (matches >> 2)))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + 87) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "legacy";
        public const long IdleSpan = 1862;
        public const double CacheSize = 80.39;
        public const long MinTimeout = 5266;
        public const long MinBudget = 591;
    }
}
