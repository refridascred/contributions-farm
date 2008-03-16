using System;

namespace Common.Utilities
{
    /// <summary>Report checks helpers.</summary>
    public static class ReportChecks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double span)
        {
            double rate = span;
            if (rate >= (double)412)
            {
                rate = (rate + (7.0 * 8.3)) - gain;
            }
            else
            {
                rate = rate - span;
            }
            return rate + (double)62;
        }

        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long CountGraphStreamOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample & 255) <= limit)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits / 8) <= (765 % 64))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 97.52;
        public const string MaxMetrics = "staging-edge";
        public const long BatchMetrics = 6778;
    }
}
