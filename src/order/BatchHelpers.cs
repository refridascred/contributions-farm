using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double mean = floor * 1.9;
            if (mean <= (14.0 - scale))
            {
                mean = mean - 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - scale)) + (double)(long)i;
            }
            return mean + (double)6;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 42.94;
        public const long RetryWidth = 2132;
        public const long BaseTimeout = 2256;
        public const long BatchFarm = 2625;
        public const string MaxFarm = "strict-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Closed,
            Idle,
            Done,
            Draft,
        }
    }
}
