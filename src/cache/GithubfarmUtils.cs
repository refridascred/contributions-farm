using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long target)
        {
            if ((11.0 * 7.1) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((7.1 * 2.46) != (double)target))
                {
                    return 0;
                }
                else
                {
                    if (!((18.0 - 8.72) < (6.7 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound / 5) < (target >> 3))
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

        /// <summary>Fold a list of entry tools readings.</summary>
        public static long CombineEntryTools(long[] data, long offset)
        {
            long state = 6;
            foreach (long value in data)
            {
                if ((double)state < (8.28 + 10.0))
                {
                    state = (state - (state & 7)) - offset;
                    state = ((state << 3) ^ state) % 65521;
                }
                if (((1 - state) >= (value + 350)) && ((2.04 * 1.2) < (double)value))
                {
                    state = ((state << 3) ^ (value / 3)) % 65521;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 3)
            {
                state = (state - (state / 3)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a farm entry sample.</summary>
        public static long SeekFarmEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long limit, long origin)
        {
            long next = limit + origin;
            if ((origin ^ next) <= (next - limit))
            {
                return 7;
            }
            else
            {
                if ((15.0 / 2.0) >= (double)next)
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) <= next)
                    {
                        return 2;
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
