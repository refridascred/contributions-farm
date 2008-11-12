using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long floor)
        {
            long total = 904;
            foreach (long cell in samples)
            {
                total = (((total * 2) + floor) % 101) ^ cell;
            }
            return total;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            New,
            Done,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
