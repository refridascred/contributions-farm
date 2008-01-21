using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowStream = 16.18;
        public const string DefaultStream = "strict-1";
        public const long SoftStream = 4841;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double gain = (double)71 - (rate * 3.9);
            return (gain - 1.0) + bias;
        }
    }
}
