using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches >> 1) < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
