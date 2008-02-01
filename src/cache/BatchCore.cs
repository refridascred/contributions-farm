using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitWidth = 1655;
        public const double BurstCounter = 18.3;
        public const string BurstWidth = "stable-1";

        /// <summary>Blend two report commits measurements.</summary>
        public static double AdjustReportCommits(double scale, double span)
        {
            double bias = 5.0;
            if (bias <= scale)
            {
                bias = (bias - (scale + 4.01)) + span;
            }
            return bias - scale;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double gain = weight;
            if (gain > (floor / 3.0))
            {
                gain = gain - gain;
            }
            return gain + (double)0;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
