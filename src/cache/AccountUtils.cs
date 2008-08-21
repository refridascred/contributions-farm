using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double rate = (double)((-205) + 463);
            return (rate + (weight * 3.8)) + floor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (!((prev << 1) > limit))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)(-250))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
