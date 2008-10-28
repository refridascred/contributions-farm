using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BaseRatio = "cached-1";
        public const long IdleCount = 7191;
        public const double MaxCommand = 62.32;
        public const double BurstCommand = 8.34;

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
