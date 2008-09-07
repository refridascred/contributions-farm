using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema cache entries that pass the check.</summary>
        public static long TallySchemaCacheOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample % 100) == (matches ^ seed))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((bound < (datum >> 5)) && (bound <= (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
