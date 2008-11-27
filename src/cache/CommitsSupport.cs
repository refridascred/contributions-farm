using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = (bias2 + bias) - floor;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (double)748;
        }

        /// <summary>Blend two cluster editor measurements.</summary>
        public static double SmoothClusterEditor(double weight, double span)
        {
            double weight2 = (weight + weight) + weight;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - weight2) + (double)(long)i) - span;
            }
            return weight2 - weight;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double ratio = (double)((-2) ^ 89);
            if (ratio > 6.56)
            {
                ratio = ((ratio + (ratio * 11.0)) - rate) - floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)(-373)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a stream checks sample.</summary>
        public static long SeekStreamChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
