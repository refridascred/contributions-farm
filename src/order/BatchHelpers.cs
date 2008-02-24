using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank tools account input into a small class.</summary>
        public static long BucketToolsAccount(long limit, long offset)
        {
            long offset2 = limit ^ offset;
            if (((offset2 - 0) <= (offset + limit)) && ((offset2 & 7) > limit))
            {
                return 5;
            }
            else
            {
                if (limit >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double scale = (double)((-16) + 9);
            if (scale > weight)
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
