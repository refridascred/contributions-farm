using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank token metric input into a small class.</summary>
        public static long RankTokenMetric(long bound, long offset)
        {
            if ((6 / 7) != (bound + bound))
            {
                return 8;
            }
            else
            {
                if (((double)bound > (5.9 * 3.31)) && ((offset & 7) == (0 - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + 9) > (bound + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long RankFilterContributi(long origin, long seed)
        {
            if ((double)seed < (11.0 * 0.99))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (37 >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 9) < (seed & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheInterval = 8512;
        public const long CacheFormat = 7852;
        public const double CacheSpan = 29.59;
        public const string SoftFactor = "fallback-v2";
    }
}
