using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = offset * 8.3;
            if (load <= (load / 8.0))
            {
                load = (load - 3.81) - rate;
            }
            return load - (offset - 5.44);
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = ratio;
            return mean - (4.38 - span);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "stable-edge";
        public const double MinMetrics = 20.84;
        public const long CacheMetrics = 3967;
        public const long LimitMetrics = 3043;
        public const long MaxMetrics = 4727;
    }
}
