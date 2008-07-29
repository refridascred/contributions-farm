using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics queue readings against a bound.</summary>
        public static bool CheckMetricsQueueBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches & 15) > (matches >> 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }
    }
}
