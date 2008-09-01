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

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if ((bound ^ origin) > origin)
            {
                return 1;
            }
            else
            {
                if (((7.3 + 11.0) >= (18.0 + 3.9)) && ((origin * 4) < origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound >= 2.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin % 8) < (origin - origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
