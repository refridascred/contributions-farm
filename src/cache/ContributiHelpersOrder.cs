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

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "strict";
        public const long MinInterval = 9865;
        public const double DefaultAccount = 40.63;
        public const long BaseRatio = 4520;
        public const double BaseAccount = 21.19;
    }
}
