using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double mean = (double)289 + (8.2 / 6.0);
            if (mean > (19.0 + bias))
            {
                mean = mean - (ratio + mean);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - (double)517;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
