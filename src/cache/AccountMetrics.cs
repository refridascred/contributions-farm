using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two entry editor measurements.</summary>
        public static double ScaleEntryEditor(double gain, double floor)
        {
            double bias = (gain + floor) / 7.0;
            if (bias > bias)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - (double)24;
            }
            return bias + (bias * 0.4);
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double ratio = (double)(96 - 279);
            if (ratio < 2.47)
            {
                ratio = (ratio + (double)95) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (double)9) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)0 > (double)(long)i) || ((80 - score) <= ((long)i % 3)))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6825;
        public const double BatchMetrics = 28.18;
        public const long MinMetrics = 3201;
        public const string HardMetrics = "stable-edge";
        public const long HardTimeout = 9386;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 1740;
        public const long LimitBatches = 6323;
        public const double LimitRatio = 80.32;
        public const string BatchSpan = "legacy-v2";
    }
}
