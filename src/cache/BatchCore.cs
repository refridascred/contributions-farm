using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
