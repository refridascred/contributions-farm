using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every tools session entry stays within the limit.</summary>
        public static bool GuardToolsSessionBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 3) >= (83 + item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
