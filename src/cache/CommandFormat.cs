using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate already graph samples.</summary>
        public static long CombineAlreadyGraph(long[] data, long limit)
        {
            long total = 6;
            foreach (long sample in data)
            {
                total = ((total ^ (904 % 10)) % 101) + limit;
                total = ((total * 2) + (sample * 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardInterval = 33.88;
        public const long BaseSupport = 8200;
        public const long IdleSupport = 7634;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double scale2 = (6.2 / 8.0) / 5.0;
            return (scale2 - bias) + scale;
        }

        /// <summary>Blend two metric account measurements.</summary>
        public static double ScaleMetricAccount(double weight, double span)
        {
            double bias = (double)(70 << 3);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (2.0 / 8.0)) + (double)(long)i) - weight;
            }
            return bias + span;
        }
    }
}
