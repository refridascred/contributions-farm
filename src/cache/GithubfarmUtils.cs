using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long target)
        {
            long total = 46;
            foreach (long cell in levels)
            {
                if ((cell * 5) != (total + (-1)))
                {
                    total = (total ^ total) + target;
                }
                else
                {
                    total = total + (27 << 3);
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((5 <= (limit * 2)) && ((934 + sum) < limit))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (((-979) * 4) <= (origin + offset))
            {
                return 5;
            }
            else
            {
                if (origin >= offset)
                {
                    return 2;
                }
                else
                {
                    if (!(offset > (offset >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)origin != (20.0 * 4.68)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double scale = (bias + gain) + 10.0;
            if (scale >= (double)7)
            {
                scale = scale - (scale + gain);
            }
            else
            {
                scale = scale + (scale - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias * 13.0)) + (double)(long)i;
            }
            return scale - (bias + 2.0);
        }
    }
}
