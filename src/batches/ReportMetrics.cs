using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((-33) >> 4) <= (5 - entry)) || ((entry - origin) == (origin & 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
