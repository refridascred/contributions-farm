using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long SeriesSessionMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 4) + mix;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7382;
        public const double BurstRatio = 84.86;
        public const long BurstGraph = 2237;
    }
}
