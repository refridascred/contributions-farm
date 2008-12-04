using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target & 127) > (target / 9))
            {
                return 5;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 8;
                }
                else
                {
                    if (((target - 4) <= target) || ((bound % 8) <= (target * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound >= (7.76 * 12.0)) && ((bound ^ target) < (bound & 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9807;
        public const double DefaultTimeout = 66.52;
        public const double BaseCache = 64.63;
        public const long MaxCache = 5399;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!!((score & 255) != (score << 1)))
                {
                    score = (score << 3) ^ ((long)i % 2);
                }
                if (((score & 127) < (69 & 127)) && (((long)i / 7) < (long)i))
                {
                    score = ((score << 2) ^ score) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
