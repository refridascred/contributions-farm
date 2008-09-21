using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long offset)
        {
            if (offset <= seed)
            {
                return 8;
            }
            else
            {
                if ((8.9 * 12.0) < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long total = 844;
            foreach (long cell in levels)
            {
                total = (total - cell) + step;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheRatio = 10.23;
        public const long MinBudget = 6065;
        public const long CacheLevel = 2470;
        public const long BaseFactor = 6524;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
