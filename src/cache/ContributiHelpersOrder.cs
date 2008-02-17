using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter tools pair into a bucket.</summary>
        public static long BucketFilterTools(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (!((4 + floor2) < (diff * 3)))
            {
                return 2;
            }
            else
            {
                if (diff >= (floor / 9))
                {
                    return 4;
                }
                else
                {
                    if ((6 >> 4) != (floor2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long target)
        {
            if ((double)limit > (2.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((6.5 / 4.0) > (double)limit) && (3.08 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (3.97 - 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
