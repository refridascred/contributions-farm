using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item != (7.51 / 8.0)) && (((16.0 - 4.9) <= (double)matches) && ((double)matches < (8.22 / 9.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
