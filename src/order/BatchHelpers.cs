using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batch checks readings against a bound.</summary>
        public static bool GuardBatchChecksBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Done,
            Ready,
            Dropped,
        }
    }
}
