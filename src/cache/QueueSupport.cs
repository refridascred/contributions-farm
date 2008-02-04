using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double weight2 = (offset / 5.0) - (offset / 4.0);
            if (weight2 > (weight2 * 7.9))
            {
                weight2 = weight2 + 1.7;
            }
            else
            {
                weight2 = weight2 - (weight + weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 - offset;
        }

        /// <summary>Project the next cache report value.</summary>
        public static double SmoothCacheReport(double gain, double offset)
        {
            double ratio = (double)7 - (offset / 4.0);
            if (ratio < (double)35)
            {
                ratio = (ratio + 12.0) - gain;
            }
            return ratio + (offset - offset);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
