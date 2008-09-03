using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                double mean = (4.7 + 2.5) - (10.0 - 13.0);
                score = ((score * 4) + (origin & 127)) % 4096;
                if ((mean < (1.99 / 5.0)) && ((mean * 0.03) != (mean / 3.0)))
                {
                    score = (score * 3) + (origin + (long)i);
                    mean = mean - (9.6 / 9.0);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count graph tools pairs that satisfy a relation.</summary>
        public static long CompareGraphToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (floor >= (146 << 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) > (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
