using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "primary";
        public const long DefaultFactor = 6173;
        public const long MaxGraph = 5729;
        public const long RetryGraph = 2823;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double weight = ratio;
            if (weight >= (double)515)
            {
                weight = weight - (ratio / 8.0);
            }
            return weight - (span + weight);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Closed,
            Active,
            Done,
        }
    }
}
