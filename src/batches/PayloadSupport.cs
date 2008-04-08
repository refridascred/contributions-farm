using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double mean = (double)(78 + 93);
            if (mean >= (bias + mean))
            {
                mean = (mean + bias) - rate;
            }
            else
            {
                mean = mean - (bias * 16.0);
            }
            return mean - mean;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSpan = 1755;
        public const long WindowSpan = 419;
        public const long HardGraph = 8532;
        public const double BurstSize = 98.55;
    }
}
