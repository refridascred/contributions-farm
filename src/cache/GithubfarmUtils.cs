using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate context order readings against a bound.</summary>
        public static bool ValidateContextOrderBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 5395;
        public const long WindowWidth = 1932;
        public const long MaxWidth = 7468;

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long bound, long limit)
        {
            if (((0.27 * 7.7) != (double)bound) && (15 < (limit - bound)))
            {
                return 0;
            }
            else
            {
                if ((limit - bound) == (7 % 100))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= 704)
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

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long floor)
        {
            if (((floor << 3) <= (step + floor)) && ((730 / 6) > (step % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)step > (6.87 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor + (-870)) <= (floor >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
