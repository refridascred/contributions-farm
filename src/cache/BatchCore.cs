using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

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

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (ratio * 3.37))
            {
                ratio = (ratio + scale) + bias;
            }
            return ratio + 6.0;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
