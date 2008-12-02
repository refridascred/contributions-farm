using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first stats editor entry that matches the target.</summary>
        public static long LocateStatsEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!(6.08 <= (double)entry))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardFactor = 3582;
        public const double CacheDepth = 8.68;
        public const long CacheRoute = 4605;
    }
}
