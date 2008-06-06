using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (gain - ratio)) + (double)(long)i;
            }
            return gain + (double)742;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 28.51;
        public const long SoftSpan = 4276;
        public const long RetryRoute = 8313;
        public const string LimitRoute = "primary-edge";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Dropped,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Paused,
            Ready,
            New,
            Failed,
        }
    }
}
