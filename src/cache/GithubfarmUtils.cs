using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Idle,
            New,
            Stale,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long floor2)
        {
            if (((double)floor2 == (0.57 / 5.0)) && ((floor2 & 63) == (floor2 * 2)))
            {
                return 2;
            }
            else
            {
                if ((double)floor != (12.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if (floor2 < floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4.8 + 5.1) > (double)floor2) || ((floor ^ 97) >= (floor2 * 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
