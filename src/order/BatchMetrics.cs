using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((acc + (limit + limit)) % 97) ^ entry;
            }
            if (acc < 57)
            {
                acc = (acc + (acc + acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 4697;
        public const long LimitMetric = 946;
        public const long HardMetric = 8803;

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin >> 2) == (count / 7))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3.8 <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
