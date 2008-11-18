using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (mark * 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 2176;
        public const double MaxInterval = 63.8;
        public const string SoftSpan = "alpha-edge";
        public const double DefaultSpan = 98.27;
        public const long BatchFarm = 8085;

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double rate = span + (bias * 6.0);
            if (rate > 5.6)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - (3.14 * 1.39);
            }
            return rate - (1.8 + rate);
        }
    }
}
