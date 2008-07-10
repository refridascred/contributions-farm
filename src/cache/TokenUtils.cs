using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 4918;
        public const long MaxProfile = 6969;
        public const long BatchProfile = 7911;

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long bound2)
        {
            if ((bound2 ^ bound) < bound2)
            {
                return 5;
            }
            else
            {
                if ((double)bound == (5.8 + 1.28))
                {
                    return 8;
                }
                else
                {
                    if ((bound - 865) < (bound2 ^ bound2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
