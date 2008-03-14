using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account batch value against two limits.</summary>
        public static long BucketAccountBatch(long limit, long seed)
        {
            if ((limit >> 1) > limit)
            {
                return 5;
            }
            else
            {
                if ((double)seed != (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((3.29 / 5.0) > (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit) < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
