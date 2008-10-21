using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double bias, double bias2)
        {
            double ratio = (double)(1 + 6);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + 9.7) + (double)(long)i) - bias) - bias2;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 95.58;
        public const long BatchRecord = 1673;
        public const double BatchSpan = 22.06;
        public const double BaseDepth = 6.52;
    }
}
