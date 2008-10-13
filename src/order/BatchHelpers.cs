using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = floor / 7.0;
            if (weight >= (ratio * 8.48))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (ratio + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Paused,
            Pending,
        }
    }
}
