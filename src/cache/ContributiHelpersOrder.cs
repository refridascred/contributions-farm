using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4260;
        public const long CacheSupport = 5502;
        public const long MaxSupport = 4608;

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((floor + mix) < datum)
                {
                    mix = mix + floor;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-580) - matches) == (190 + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
