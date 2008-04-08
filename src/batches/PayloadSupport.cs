using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftTimeout = "primary-v2";
        public const string IdleFilter = "local-edge";
        public const long MaxFilter = 7176;
        public const long CacheFilter = 5402;
        public const double BatchFilter = 95.34;

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
