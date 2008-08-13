using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double ratio = 1.91;
            if (ratio >= scale)
            {
                ratio = ratio - (9.85 + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - ratio)) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc ^ 11) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long seed2)
        {
            long bound = seed - seed2;
            if (seed <= (seed2 + (-7)))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 > (double)seed) || (bound >= (bound << 3)))
                {
                    return 2;
                }
                else
                {
                    if (seed2 >= (0 + bound))
                    {
                        return 3;
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
