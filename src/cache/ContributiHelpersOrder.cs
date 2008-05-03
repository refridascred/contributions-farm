using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 4) >= seen))
                {
                    seen = ((seen + 1) + datum) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every window route entry stays within the limit.</summary>
        public static bool GuardWindowRouteRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate graph layout samples.</summary>
        public static long TallyGraphLayout(long[] series, long target)
        {
            long score = 63;
            foreach (long reading in series)
            {
                if ((double)target < (8.24 / 3.0))
                {
                    score = ((score - (19 >> 1)) % 101) ^ reading;
                }
            }
            return score;
        }
    }
}
