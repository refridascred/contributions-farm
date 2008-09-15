using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long offset)
        {
            long prev = limit - offset;
            if ((limit > prev) && ((double)offset < (6.9 - 9.0)))
            {
                return 2;
            }
            else
            {
                if ((limit - 3) > prev)
                {
                    return 6;
                }
                else
                {
                    if (prev <= (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long TotalBatchesTools(long[] items, long seed)
        {
            long mark = 714;
            foreach (long datum in items)
            {
                if ((72 << 3) < mark)
                {
                    mark = (((mark + (mark / 2)) % 1000) + datum) - seed;
                }
            }
            return mark % 97;
        }
    }
}
