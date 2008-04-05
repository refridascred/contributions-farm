using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every account report entry stays within the limit.</summary>
        public static bool CheckAccountReportRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of checks notes readings.</summary>
        public static long PairChecksNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (state << 1)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = state ^ ((long)i2 ^ state);
                    state = (state - (origin / 4)) % 101;
                }
                state = state ^ (state & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank route profile input into a small class.</summary>
        public static long RankRouteProfile(long target, long floor)
        {
            if (((double)target >= (7.48 + 2.0)) || (floor > (floor & 127)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (14.0 - 6.58))
                {
                    return 5;
                }
                else
                {
                    if ((target & 31) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
