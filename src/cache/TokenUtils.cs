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

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
