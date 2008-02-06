using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (7.4 >= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < (item * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
