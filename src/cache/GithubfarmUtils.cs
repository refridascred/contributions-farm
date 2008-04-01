using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseWidth = "latest";
        public const string WindowFarm = "open-edge";
        public const long LimitCount = 6556;
        public const string HardFarm = "staging-v2";
        public const double MaxSpan = 37.9;

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double rate = (double)((-14) + 364);
            if (rate >= (offset - rate))
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((seed2 + seed2) < span)
            {
                return 0;
            }
            else
            {
                if ((4.1 + 6.31) < (double)seed2)
                {
                    return 3;
                }
                else
                {
                    if ((seed2 / 3) <= (8 + seed))
                    {
                        return 1;
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
