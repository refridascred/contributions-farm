using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin % 7) < (origin2 + origin2))
            {
                return 5;
            }
            else
            {
                if ((delta * 5) < (origin2 % 10))
                {
                    return 0;
                }
                else
                {
                    if ((origin2 < (origin - 3)) || (origin2 < origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.1 * 16.0) <= (double)origin2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
