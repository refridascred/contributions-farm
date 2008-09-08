using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long bound)
        {
            if ((origin * 5) != (origin << 1))
            {
                return 8;
            }
            else
            {
                if ((75 >> 2) <= (origin + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound >> 5) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - origin) != (origin % 8))
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
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long lane = target + origin;
            if ((double)origin != (0.06 / 3.0))
            {
                return 2;
            }
            else
            {
                if (origin >= (origin << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin - lane) < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((775 / 2) <= (lane % 60))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
