using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const long BatchLevel = 6792;
        public const string BatchToken = "cached-edge";
        public const long RetryCount = 530;

        /// <summary>Rank filter token input into a small class.</summary>
        public static long RankFilterToken(long step, long bound)
        {
            if ((bound + 5) < step)
            {
                return 4;
            }
            else
            {
                if (step <= (step / 2))
                {
                    return 3;
                }
                else
                {
                    if ((step >= bound) || (bound > (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
