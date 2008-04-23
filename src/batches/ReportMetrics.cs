using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Synced,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell > (4.0 * 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
