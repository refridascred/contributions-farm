using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((floor * 5) < (tally - floor))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "local";
        public const string WindowNotes = "primary-v2";
        public const long SoftNotes = 6751;
        public const double LimitNotes = 40.01;

        /// <summary>Audit notes route readings against a rule.</summary>
        public static long MeasureNotesRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)14 != (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
