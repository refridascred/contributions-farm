using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a cluster metrics sample.</summary>
        public static long SeekClusterMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((mark % 7) <= (635 ^ 2)) && (((long)i - limit) >= (mark << 1)))
                {
                    mark = ((mark << 3) ^ (limit & 127)) % 97;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the order buffer entries that pass the check.</summary>
        public static long AuditOrderBufferHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(5 > (17 + cell)))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
