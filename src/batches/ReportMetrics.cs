using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
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
