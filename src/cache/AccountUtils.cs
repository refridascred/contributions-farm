using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double weight, double bias)
        {
            double ratio = bias;
            if (ratio <= (ratio / 8.0))
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 1.5) + (double)(long)i;
            }
            return ratio - (double)1;
        }

        /// <summary>Rank schema counter input into a small class.</summary>
        public static long RankSchemaCounter(long floor, long offset)
        {
            if ((1.4 - 7.97) == (double)offset)
            {
                return 3;
            }
            else
            {
                if (!((double)offset != (5.0 + 8.7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double scale = floor * 8.0;
            return (scale + (double)821) + gain;
        }
    }
}
