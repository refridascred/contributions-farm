using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) != (75 & 1))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long ClassifyBatchesFilter(long limit, long bound)
        {
            long diff = limit + bound;
            if (bound >= (56 + 27))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (0.6 - 4.0))
                {
                    return 3;
                }
                else
                {
                    if (!((98 + limit) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long SortStatsChecks(long floor, long limit)
        {
            if ((floor - floor) == (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((floor / 9) <= (limit & 1))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up token tools samples.</summary>
        public static long MatchTokenToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
