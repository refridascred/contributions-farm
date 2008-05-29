using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open-1";
        public const double MaxCommand = 63.25;
        public const long BatchCommand = 6680;

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 4871;
        public const long StepStats = 3700;
        public const string IdleStats = "primary-1";

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)39)
            {
                ratio = (ratio + (ratio * 19.0)) - weight;
            }
            return ratio - ratio;
        }
    }
}
