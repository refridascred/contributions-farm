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

        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long BucketRouteChecks(long bound, long step)
        {
            if ((bound / 2) < (bound - step))
            {
                return 4;
            }
            else
            {
                if ((step + step) > (0 - bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (bound - step))
                    {
                        return 6;
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
