using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter tools samples are out of range.</summary>
        public static long MeasureFilterToolsHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches ^ cell) != (matches / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
