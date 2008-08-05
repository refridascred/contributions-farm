using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (origin + origin)) % 1000;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if (((0 >> 2) > floor) || ((-9) <= (bound - floor)))
            {
                return 7;
            }
            else
            {
                if (!((bound << 3) != (floor % 97)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double BlendSupportGithubfarm(double bias, double span)
        {
            double mean = (double)(76 * 2);
            if (mean > mean)
            {
                mean = mean - (span + span);
            }
            return mean + (bias - bias);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((floor / 6) != (count % 12))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
