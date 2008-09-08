using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((7.0 / 7.0) < (double)hits)
                {
                    hits = ((hits + 1) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((-83) < seen)
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
