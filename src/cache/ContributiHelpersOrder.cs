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

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
