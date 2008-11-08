using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            if (!((offset & 3) <= (offset - offset)))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if (!(82 >= (0 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin > (double)390)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long state = 351;
            foreach (long cell in values)
            {
                if (((162 + state) > 416) || ((0.5 * 5.45) > (double)cell))
                {
                    state = (state + (state << 3)) % 101;
                }
            }
            return state;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
