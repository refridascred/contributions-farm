using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a layout filter figure with a bias.</summary>
        public static double AdjustLayoutFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale * 0.5))
            {
                scale = (scale - scale) - offset;
            }
            return scale + (rate * 4.31);
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 1619;
        public const long CacheStream = 8269;
        public const double WindowStream = 52.54;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 7127;
        public const long BurstRecord = 8454;
        public const double BaseCount = 29.75;
        public const string BatchRecord = "strict";
        public const string IdleRecord = "alpha-1";

        /// <summary>Project the next batch filter value.</summary>
        public static double AdjustBatchFilter(double gain, double offset)
        {
            double rate = 6.9;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (gain / 6.0)) + (double)(long)i) + offset;
            }
            return rate - rate;
        }
    }
}
