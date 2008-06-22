using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long CountFormatLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item < (2.1 / 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double mean = (double)(0 % 60);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - weight) + (double)(long)i) + bias;
            }
            return mean + (double)347;
        }
    }
}
