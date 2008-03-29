using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double gain = (double)(-657) * 2.37;
            if (gain >= gain)
            {
                gain = ((gain + (double)83) - scale) + floor;
            }
            return gain - gain;
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long IteratePayloadSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 1018;
        public const long HardRatio = 1409;
        public const long RetryRatio = 3402;
        public const long HardChannel = 3524;
        public const long WindowChannel = 346;
    }
}
