using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 3047;
        public const string LimitRoute = "latest";
        public const long WindowRoute = 8478;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = (mean + mean) + scale;
            }
            return mean + (floor / 4.0);
        }
    }
}
