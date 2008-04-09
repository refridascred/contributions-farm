using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 58.6;
        public const string BatchFactor = "staging-v2";
        public const long CacheLevel = 3703;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double ratio, double offset)
        {
            double drift = (double)(56 ^ 51);
            if (drift < (drift + offset))
            {
                drift = (drift + offset) + ratio;
            }
            else
            {
                drift = drift - (4.48 - 8.5);
            }
            return drift - drift;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Ready,
            Dropped,
        }
    }
}
