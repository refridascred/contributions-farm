using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitRatio = 6738;
        public const long BaseCount = 7814;
        public const long IdleEditor = 3845;
        public const long MinEditor = 651;
        public const long CacheBudget = 5118;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] items)
        {
            long mark = -99;
            foreach (long cell in items)
            {
                mark = ((mark - (27 & 63)) % 1000) + cell;
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark;
        }
    }
}
