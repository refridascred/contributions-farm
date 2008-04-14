using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session commits readings.</summary>
        public static long OverlapSessionCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long origin)
        {
            if (floor > (origin + origin))
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((origin > (floor >> 5)) && ((floor - origin) != (floor - 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >= floor) || ((origin & 7) != (floor + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
