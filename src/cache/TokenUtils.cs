using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long offset)
        {
            if ((3.1 >= (double)limit) || ((687 + 733) <= offset))
            {
                return 5;
            }
            else
            {
                if ((698 >> 5) != (limit >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (8.0 + 8.37))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double rate = bias;
            if (rate <= scale)
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)695) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
