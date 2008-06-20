using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            New,
            Active,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 23.52;
        public const string WindowAccount = "primary-edge";
        public const long LimitAccount = 2531;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double mean = scale + 2.98;
            if (mean <= offset)
            {
                mean = mean - (double)47;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - scale;
        }
    }
}
