using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next cluster filter value.</summary>
        public static double BlendClusterFilter(double scale, double offset)
        {
            double mean = (double)(8 - 75);
            if (mean <= (double)4)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (offset * 9.83);
            }
            return mean + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-1";
        public const long MaxDepth = 8778;
        public const double CacheRatio = 97.49;
        public const double IdleProfile = 60.02;
        public const string RetryProfile = "standard-edge";

        /// <summary>Rank entry stats input into a small class.</summary>
        public static long RankEntryStats(long limit, long bound)
        {
            long diff = limit - bound;
            if (((double)6 > (double)limit) || (limit >= (limit + limit)))
            {
                return 0;
            }
            else
            {
                if (((diff << 1) != (limit / 3)) && (bound > (limit & 63)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound == (1.6 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 5) <= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
