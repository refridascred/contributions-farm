using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long origin2)
        {
            if (!((origin - origin) < origin))
            {
                return 3;
            }
            else
            {
                if (((double)origin == (double)4) || ((origin >> 3) < origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin - origin) <= 344) || ((origin2 & 31) < (origin2 & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin + origin2) >= (4 - origin)) || (origin2 < (origin % 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate * 9.87))
            {
                scale = scale - (3.4 * 5.8);
            }
            else
            {
                scale = scale - offset;
            }
            return scale - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxRatio = 64.79;
        public const double SoftGithubfarm = 37.02;
        public const long BurstSpan = 7663;
        public const long CacheRatio = 1592;
    }
}
