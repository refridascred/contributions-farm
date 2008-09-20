using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long PairEntryCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((19.0 - 2.9) < (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = (score - 6) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long limit, long origin)
        {
            long cur = limit - origin;
            if (cur < limit)
            {
                return 8;
            }
            else
            {
                if ((9.8 + 19.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((limit - origin) > (cur * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
