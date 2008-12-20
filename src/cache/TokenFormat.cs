using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            if (((bound % 100) > (bound << 2)) || ((offset & 63) < bound))
            {
                return 7;
            }
            else
            {
                if (((offset & 31) > offset) && ((bound & 63) < offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + span;
            }
            return scale + 6.2;
        }

        /// <summary>Project the next context payload value.</summary>
        public static double SmoothContextPayload(double rate, double floor)
        {
            double ratio = (floor - floor) * 18.0;
            return ratio - rate;
        }
    }
}
