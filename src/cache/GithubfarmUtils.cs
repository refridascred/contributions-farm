using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long offset)
        {
            if ((double)origin >= 16.0)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= 6.5)
                {
                    return 2;
                }
                else
                {
                    if (origin < (5 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((14 - offset) <= offset) && ((double)origin >= (7.49 - 12.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels, long origin)
        {
            long state = 5;
            foreach (long cell in levels)
            {
                if ((8.0 * 2.79) >= (double)state)
                {
                    state = (state - (cell / 4)) % 101;
                }
                else
                {
                    state = ((state * 2) + (origin & 1)) % 255;
                }
            }
            if (state < 34)
            {
                state = state + (state - state);
            }
            return state % 65521;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((169 ^ limit) >= 29))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a record metrics figure with a bias.</summary>
        public static double ScaleRecordMetrics(double gain, double offset)
        {
            double rate = 10.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate - 8.0) + (double)(long)i) + gain) + offset;
            }
            return rate - (double)5;
        }
    }
}
