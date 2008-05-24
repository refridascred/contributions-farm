using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long StepClusterBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long limit)
        {
            long cur = bound ^ limit;
            if ((double)cur <= (11.0 * 7.35))
            {
                return 4;
            }
            else
            {
                if (((double)cur >= (7.0 / 7.0)) || ((limit - cur) >= (limit >> 5)))
                {
                    return 0;
                }
                else
                {
                    if ((double)cur > (double)limit)
                    {
                        return 7;
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
