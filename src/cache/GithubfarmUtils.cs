using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double scale = (8.0 * 14.0) + 8.2;
            if (scale > rate)
            {
                scale = scale - (4.3 - span);
            }
            else
            {
                scale = scale + (3.5 * 0.8);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long seed)
        {
            if ((seed * 4) != (seed >> 1))
            {
                return 0;
            }
            else
            {
                if ((seed % 10) > 83)
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) > 14)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long offset2)
        {
            if ((offset + 355) != (41 + offset2))
            {
                return 4;
            }
            else
            {
                if ((offset2 >> 3) < offset2)
                {
                    return 0;
                }
                else
                {
                    if ((offset + 536) == (offset2 >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset2 >= 9)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
