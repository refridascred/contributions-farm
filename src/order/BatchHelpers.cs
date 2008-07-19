using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long limit)
        {
            if (((limit >> 3) >= limit) && ((double)68 >= (double)target))
            {
                return 3;
            }
            else
            {
                if ((target * 5) == (limit << 1))
                {
                    return 5;
                }
                else
                {
                    if (((6.1 - 14.0) != (double)limit) && ((target + limit) != (limit / 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 3) < limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
