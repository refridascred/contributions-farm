using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long bound, long floor)
        {
            if ((2.19 - 4.42) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((bound << 2) == (bound ^ 640))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) > (floor % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound >= (7.7 - 9.3)) || (bound >= (13 << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((double)step != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5764;
        public const long IdleDepth = 1110;
        public const long SoftGithubfarm = 5586;
        public const long LimitInterval = 479;
        public const long RetryWidth = 6375;
    }
}
