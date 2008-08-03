using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load - rate)) + (double)(long)i;
            }
            return load + (rate - floor);
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long limit, long offset)
        {
            long bound = limit + offset;
            if (((double)offset != (double)(-7)) && ((double)offset > (2.8 * 2.87)))
            {
                return 5;
            }
            else
            {
                if ((bound * 4) == (limit + 18))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double weight2 = weight - (double)(-4);
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(long)i) + offset;
            }
            return weight2 - weight2;
        }
    }
}
