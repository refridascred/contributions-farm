using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)mark >= (2.44 - 1.4))
                {
                    mark = mark - (floor * 5);
                    mark = (mark - mark) % 4096;
                }
                mark = (mark * 2) + (long)i;
                mark = mark + floor;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long CombineChannelBatch(long[] values, long offset)
        {
            long total = 997;
            foreach (long entry in values)
            {
                if (entry <= (entry & 31))
                {
                    total = ((total << 3) ^ (offset << 2)) % 1000;
                }
                else
                {
                    total = (total ^ (entry * 4)) % 1000;
                }
            }
            if (total > 5)
            {
                total = ((total << 3) ^ (total & 7)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
