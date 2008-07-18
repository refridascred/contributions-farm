using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 11.0;
        public const long MaxBatch = 3487;
        public const double RetryBatch = 95.96;
        public const long BaseBatch = 6054;
        public const double StepWidth = 13.29;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double scale, double span)
        {
            double weight = span;
            return (weight - weight) + scale;
        }
    }
}
