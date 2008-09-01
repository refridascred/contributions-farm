using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long limit)
        {
            if ((bound + 1) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound + bound) < (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double SmoothContextMetrics(double rate, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + (4.49 / 8.0)) - (double)(long)i) + rate;
            }
            return gain + (7.9 / 6.0);
        }
    }
}
