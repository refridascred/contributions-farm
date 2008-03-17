using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long sum = 89;
            foreach (long reading in data)
            {
                sum = ((sum * 2) + (target & 255)) + reading;
                sum = (sum ^ (target % 100)) % 4096;
            }
            if (sum > (-92))
            {
                sum = (sum - target) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Classify a order batches pair into a bucket.</summary>
        public static long BucketOrderBatches(long bound, long bound2)
        {
            long edge = bound ^ bound2;
            if ((2.34 * 3.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((bound - 7) > (edge + bound2)))
                {
                    return 2;
                }
                else
                {
                    if (bound2 <= (bound2 % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
