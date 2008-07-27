using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4854;
        public const long WindowCommits = 7600;
        public const long LimitWidth = 7583;
        public const long CacheLevel = 1550;
        public const long LimitBudget = 678;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long mix = 702;
            foreach (long entry in items)
            {
                mix = mix ^ (mix ^ entry);
            }
            if (mix > 3)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (target > (matches << 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
