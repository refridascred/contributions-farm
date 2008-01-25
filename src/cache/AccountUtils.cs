using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a batches metrics reading.</summary>
        public static double SmoothBatchesMetrics(double weight, double floor)
        {
            double mean = (double)(5 + 258);
            return ((mean - (double)640) + weight) + floor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long floor, long target)
        {
            long edge = floor ^ target;
            if (edge >= (target ^ edge))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (2.01 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
