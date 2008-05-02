using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            long cur = floor - seed;
            if ((seed + seed) == (cur << 2))
            {
                return 2;
            }
            else
            {
                if (((seed & 15) <= (seed << 3)) || ((1.0 / 8.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((4.28 + 6.0) <= (double)cur)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (target << 1)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next graph account value.</summary>
        public static double BlendGraphAccount(double scale, double span)
        {
            double gain = scale;
            if (gain > (scale + span))
            {
                gain = gain - 11.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)32) - (double)(long)i;
            }
            return gain - (gain / 6.0);
        }
    }
}
