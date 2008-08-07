using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double bias = (double)(267 >> 5);
            if (bias < (double)9)
            {
                bias = (bias - bias) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (bias / 7.0)) + (double)(long)i;
            }
            return bias + (floor + 18.0);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale + scale;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (7.45 + 3.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            New,
            Stale,
            Active,
        }
    }
}
