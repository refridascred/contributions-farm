using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double scale2 = scale - bias;
            if (scale2 <= (2.5 / 8.0))
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (6.24 + scale)) + (double)(long)i;
            }
            return scale2 + (scale2 + scale);
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
