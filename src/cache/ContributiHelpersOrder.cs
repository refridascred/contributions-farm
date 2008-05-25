using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + hits) < 22)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long CountEntryFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
