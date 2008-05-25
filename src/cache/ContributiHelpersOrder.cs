using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Dropped,
            Locked,
            Paused,
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
