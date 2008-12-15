using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= 5.1)
            {
                ratio = (ratio - (floor * 6.8)) + weight;
            }
            else
            {
                ratio = ratio - (ratio + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (floor * 4.51);
        }

        /// <summary>Digest a series of cache checks entries.</summary>
        public static long CombineCacheChecks(long[] samples)
        {
            long acc = 96;
            foreach (long reading in samples)
            {
                acc = (acc - (acc + acc)) + reading;
                acc = (acc - (acc + 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Paused,
            Pending,
            Synced,
            Retry,
        }
    }
}
