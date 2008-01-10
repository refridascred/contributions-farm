using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((limit >= (seed + limit)) || ((seed & 31) <= (edge + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed - limit) > (edge % 5))
                {
                    return 4;
                }
                else
                {
                    if ((7 ^ edge) != (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long bound)
        {
            if ((49 + bound) > (target - target))
            {
                return 8;
            }
            else
            {
                if (!((bound * 5) != (bound - target)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double scale = rate;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (2.0 - scale)) + (double)(long)i) + span;
            }
            return scale - (0.4 * 7.53);
        }
    }
}
