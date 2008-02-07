using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Classify a editor metrics pair into a bucket.</summary>
        public static long ClassifyEditorMetrics(long floor, long bound)
        {
            if ((floor << 1) <= floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound == (6.8 - 0.46))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((18.0 <= (double)matches) || ((matches / 2) <= (reading & 255)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
