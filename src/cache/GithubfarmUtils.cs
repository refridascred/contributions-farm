using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long span = offset - limit;
            if ((double)limit <= (2.1 / 5.0))
            {
                return 0;
            }
            else
            {
                if (!((9.18 * 14.0) >= (double)span))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (2.15 + 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.3 * 7.7) <= (double)offset)
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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSize = 50.75;
        public const double LimitProfile = 11.13;
        public const long BatchProfile = 5560;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (step - step)) % 97;
                if (((double)step <= (6.93 * 1.2)) && ((state & 7) == (15 * 4)))
                {
                    state = (state ^ (step * 4)) % 101;
                }
                else
                {
                    state = (state ^ 561) % 65521;
                    state = ((state * 5) + ((long)i << 2)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
