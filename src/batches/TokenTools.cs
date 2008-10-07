using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count notes cluster pairs that satisfy a relation.</summary>
        public static long MatchNotesClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long step, long floor)
        {
            long next = step ^ floor;
            if ((step + step) == (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((next >= (floor % 2)) && ((step & 7) <= (next + step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series)
        {
            long total = 52;
            foreach (long value in series)
            {
                total = (total << 3) ^ (value + (long)series.Length);
            }
            return total;
        }
    }
}
