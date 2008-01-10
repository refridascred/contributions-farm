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

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
