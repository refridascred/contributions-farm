using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "cached-v2";
        public const long CacheScore = 977;
        public const long HardAccount = 1921;
        public const long WindowRatio = 3002;

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long offset)
        {
            if (((0 & 3) != (origin + origin)) || ((origin ^ offset) == (origin - 8)))
            {
                return 6;
            }
            else
            {
                if ((origin ^ offset) < (offset - 9))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((limit % 97) == (entry & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
