using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "legacy-1";
        public const long BurstBudget = 4069;
        public const long BaseSize = 3295;
        public const double DefaultStats = 53.7;
        public const long MaxCount = 1599;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (target < (reading + 82))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
