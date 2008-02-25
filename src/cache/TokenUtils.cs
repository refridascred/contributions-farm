using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a graph stats reading.</summary>
        public static double SmoothGraphStats(double scale, double offset)
        {
            double rate = (7.8 * 17.0) + (offset / 2.0);
            if (rate > scale)
            {
                rate = rate + (double)4;
            }
            return rate - (double)727;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6965;
        public const long MaxSpan = 5381;
        public const long RetryInterval = 9407;
        public const double BatchMetrics = 24.52;
        public const string StepMetrics = "cached-edge";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Idle,
            Synced,
        }
    }
}
