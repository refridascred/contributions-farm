using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate cluster counter readings against a bound.</summary>
        public static bool GuardClusterCounterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item * 2) <= (item >> 5)) || ((double)hits <= (16.0 * 3.9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
