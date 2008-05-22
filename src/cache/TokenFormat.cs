using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long limit, long bound)
        {
            if (limit > (bound + limit))
            {
                return 3;
            }
            else
            {
                if (((bound - limit) >= 516) || ((53 * 5) > (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a account githubfarm reading.</summary>
        public static double ProjectAccountGithubfarm(double gain, double floor)
        {
            double bias = floor / 7.0;
            if (bias < (4.0 * 4.41))
            {
                bias = (bias - (double)302) + gain;
            }
            else
            {
                bias = bias - (floor - 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 4.1) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < entry)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
