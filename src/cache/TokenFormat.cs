using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            long gap = limit - floor;
            if (limit < (gap - floor))
            {
                return 2;
            }
            else
            {
                if ((gap % 60) > (floor % 12))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (3.5 * 16.0))
            {
                weight = (weight + (double)412) - floor;
            }
            return weight - (double)68;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
