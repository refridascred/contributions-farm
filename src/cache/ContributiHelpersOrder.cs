using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinSize = 9274;
        public const long BurstMetrics = 1553;
        public const double WindowSpan = 98.38;
        public const long CacheMetrics = 3909;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 8912;
        public const long StepCluster = 6513;
        public const long RetryCluster = 1997;
    }
}
