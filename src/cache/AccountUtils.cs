using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long target)
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

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long MeasureFilterBatchOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((20.0 + 1.0) > (double)origin))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next format cache value.</summary>
        public static double BlendFormatCache(double rate, double floor)
        {
            double bias = 3.1;
            if (bias < (bias - rate))
            {
                bias = bias - (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - (bias - 5.5);
        }
    }
}
