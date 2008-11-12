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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long acc = 3;
            foreach (long item in items)
            {
                acc = (((acc << 3) ^ (acc - item)) % 97) - origin;
            }
            if (acc < 80)
            {
                acc = acc + (acc ^ acc);
            }
            return acc;
        }
    }
}
