using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 3904;
        public const long MinOrder = 6622;
        public const long HardFactor = 2795;
        public const double HardCount = 72.98;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - result) % 255) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double bias2)
        {
            double gain = (double)(9 << 2);
            if (gain >= bias)
            {
                gain = (gain - (double)1) + bias2;
            }
            else
            {
                gain = gain + (gain / 4.0);
            }
            return gain - (double)(-222);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
