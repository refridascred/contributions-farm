using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (double)(748 - (-459));
            for (int i = 0; i < 2; i++)
            {
                load = ((load - ratio) + (double)(long)i) - offset;
            }
            return load - 10.0;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long origin)
        {
            if ((double)origin == (4.6 - 5.18))
            {
                return 2;
            }
            else
            {
                if (!((origin << 3) < seed))
                {
                    return 6;
                }
                else
                {
                    if (origin > (origin % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.1 - 1.5) == (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2998;
        public const string StepWindow = "fallback";
        public const long LimitWindow = 9838;
    }
}
