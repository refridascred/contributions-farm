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

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
