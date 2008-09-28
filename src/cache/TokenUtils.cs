using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] items, long floor)
        {
            long state = -865;
            foreach (long value in items)
            {
                state = ((state + (state >> 2)) ^ value) + floor;
            }
            return state;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long offset, long bound)
        {
            long delta = offset + bound;
            if ((bound ^ 8) <= (bound % 24))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)delta)
                {
                    return 5;
                }
                else
                {
                    if ((delta >= (bound / 8)) || ((bound / 6) <= delta))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
