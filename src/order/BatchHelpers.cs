using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)target <= (4.02 - 8.63))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account stats entries that pass the check.</summary>
        public static long CountAccountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((-1) + cell) == (1 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
