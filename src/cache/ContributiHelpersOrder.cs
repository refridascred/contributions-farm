using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1234;
        public const long IdleRoute = 4016;
        public const string SoftRatio = "cached-v2";
        public const string MinRoute = "alpha-1";
        public const long HardFactor = 4410;

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long MeasureStreamGraphMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) > 88) && ((offset + datum) <= (hits % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + 3) < 4)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
