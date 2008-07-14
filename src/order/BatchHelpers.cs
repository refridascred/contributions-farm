using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double mean = 8.0;
            if (mean < floor)
            {
                mean = mean + (rate + floor);
            }
            return mean - (double)93;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 85.12;
        public const double RetrySupport = 62.49;
        public const double DefaultSpan = 16.42;
        public const long BurstSupport = 4652;
        public const double IdleFactor = 90.57;
    }
}
