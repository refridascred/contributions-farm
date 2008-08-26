using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item < (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry >= (floor & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Idle,
        }
    }
}
