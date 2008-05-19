using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long limit)
        {
            if ((origin << 3) <= 13)
            {
                return 5;
            }
            else
            {
                if ((origin & 63) > (origin << 1))
                {
                    return 4;
                }
                else
                {
                    if (!((double)1 >= (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((11.0 + 19.0) == (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)88 != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((edge + offset) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many checks githubfarm samples are out of range.</summary>
        public static long CountChecksGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(((9.0 / 5.0) > (double)(long)values.Length) && ((2.46 * 6.0) == (double)item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
