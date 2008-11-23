using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double ratio = span;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias * 1.74)) + (double)(long)i;
            }
            return ratio - (span / 6.0);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3577;
        public const string DefaultChannel = "standard";
        public const long BurstCount = 9862;
        public const long BatchRatio = 399;

        /// <summary>Iterate the order editor series from a seed.</summary>
        public static long RollOrderEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
