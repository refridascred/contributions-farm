using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (96 <= (entry * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
