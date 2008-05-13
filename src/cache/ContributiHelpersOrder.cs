using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream command readings against a rule.</summary>
        public static long CountStreamCommandOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((85 >> 1) == (item - 333))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of window entry readings.</summary>
        public static long MatchWindowEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSpan = 2909;
        public const double LimitGraph = 29.28;
        public const string BatchGraph = "open-1";
        public const long HardWidth = 4625;
        public const string CacheGraph = "cached-1";
    }
}
