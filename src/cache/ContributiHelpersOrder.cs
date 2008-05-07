using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the report stats entries that pass the check.</summary>
        public static long MeasureReportStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits < (datum + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "cached-v2";
        public const long MaxInterval = 9325;
        public const long WindowFactor = 2390;
        public const long DefaultAlready = 7386;
    }
}
