using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.0 / 6.0) <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitDepth = 70.81;
        public const double StepBatch = 83.27;
        public const string SoftRatio = "alpha-v2";

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) == ((long)readings.Length ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
