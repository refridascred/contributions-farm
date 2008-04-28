using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if ((datum >> 4) <= 5)
                {
                    mark = (mark - (1 >> 4)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph commits samples are out of range.</summary>
        public static long TallyGraphCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((13.0 / 6.0) == (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
