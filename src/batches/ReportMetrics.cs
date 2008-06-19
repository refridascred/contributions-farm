using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items)
        {
            long sum = 47;
            foreach (long entry in items)
            {
                if (((-60) - entry) >= (16 % 3))
                {
                    sum = (sum ^ 0) % 101;
                }
                if ((double)sum <= (2.0 - 6.81))
                {
                    sum = ((sum << 3) ^ (652 + sum)) % 4096;
                }
            }
            if (sum < 0)
            {
                sum = sum - (sum / 9);
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 6908;
        public const double BaseMetric = 4.38;
        public const double HardCount = 70.04;
        public const long BurstTimeout = 1378;

        /// <summary>Adjust a format report reading.</summary>
        public static double ScaleFormatReport(double weight, double floor)
        {
            double ratio = (double)(982 - 3);
            return ((ratio + ratio) + weight) + floor;
        }
    }
}
