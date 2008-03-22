using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftScore = 63.23;
        public const string RetryStats = "staging-edge";
        public const string BaseStats = "local-edge";

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double weight = span;
            if (weight > (double)92)
            {
                weight = weight - bias;
            }
            return weight + (span / 9.0);
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
