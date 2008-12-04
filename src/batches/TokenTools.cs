using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target & 127) > (target / 9))
            {
                return 5;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if (((target - 4) <= target) || ((bound % 8) <= (target * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound >= (7.76 * 12.0)) && ((bound ^ target) < (bound & 3)))
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9807;
        public const double DefaultTimeout = 66.52;
        public const double BaseCache = 64.63;
        public const long MaxCache = 5399;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double rate = (floor * 6.81) / 8.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - (double)0) + (double)(long)i) - scale;
            }
            return rate - rate;
        }
    }
}
