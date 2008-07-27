using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double scale, double bias)
        {
            double rate = bias;
            if (rate < (bias - scale))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - 16.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate * 3.0)) - (double)(long)i;
            }
            return rate + (rate * 4.8);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 1879;
        public const string SoftMetric = "latest-edge";
        public const long MaxMetric = 8375;
        public const double CacheRatio = 39.55;
    }
}
