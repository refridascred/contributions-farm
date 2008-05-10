using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double BlendGraphSchema(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (6.58 * 4.9)) + (double)(long)i) + gain;
            }
            return scale - span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleDepth = 6161;
        public const long BatchTools = 1366;
        public const long HardSize = 326;
        public const string SoftTimeout = "primary";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double weight = 9.1 + (ratio + offset);
            if (weight <= ratio)
            {
                weight = weight - (weight / 4.0);
            }
            return weight - ratio;
        }
    }
}
