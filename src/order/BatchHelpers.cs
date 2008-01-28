using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen << 2) <= (seen - cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
