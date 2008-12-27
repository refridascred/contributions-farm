using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix - (mix & 15)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleScore = 71.76;
        public const long BaseSpan = 4466;
        public const long IdleRatio = 6022;
        public const long CacheProfile = 8397;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8378;
        public const string LimitMetrics = "primary-edge";
        public const double HardMetrics = 18.85;
        public const long BaseMetrics = 3764;
    }
}
