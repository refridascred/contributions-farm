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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long floor)
        {
            if ((offset % 3) > (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((floor & 31) < (floor + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((floor + 79) > (offset - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
