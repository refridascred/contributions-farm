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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long origin)
        {
            if ((origin + target) > (42 & 63))
            {
                return 5;
            }
            else
            {
                if ((origin + target) != (origin << 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
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
