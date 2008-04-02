using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of report window readings.</summary>
        public static long CompareReportWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit already filter readings against a rule.</summary>
        public static long AuditAlreadyFilterOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (7.76 + 8.0))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8.9 - 0.66) <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
