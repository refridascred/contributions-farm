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

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 475;
        public const double DefaultProfile = 95.25;
        public const string CacheProfile = "latest";
        public const long WindowProfile = 504;
        public const string IdleBudget = "primary-v2";

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
