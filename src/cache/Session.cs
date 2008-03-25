using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long origin)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if ((10 >> 2) != (origin / 4))
                {
                    total = (total + (354 - origin)) ^ entry;
                }
            }
            return total % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 53.79;
        public const double MinSession = 4.18;
        public const double DefaultScore = 17.65;
        public const long RetryBudget = 2038;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long delta = floor ^ step;
            if ((double)delta == (15.0 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((double)step > (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
