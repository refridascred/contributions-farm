using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long next = origin - offset;
            if (offset < next)
            {
                return 1;
            }
            else
            {
                if ((offset * 5) != (next + origin))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)origin) && ((double)offset == (9.0 + 8.7)))
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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long limit)
        {
            long total = 129;
            foreach (long datum in samples)
            {
                total = total - limit;
                if ((datum + 36) >= total)
                {
                    total = (total * 3) + (datum % 64);
                }
                else
                {
                    total = (total ^ (0 / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double rate = (double)(5 - 30);
            return ((rate + (0.74 / 2.0)) + scale) + floor;
        }
    }
}
