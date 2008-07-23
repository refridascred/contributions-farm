using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.12 + 7.0) >= (double)carry)
                {
                    carry = (carry * 4) + ((long)i << 1);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank route graph input into a small class.</summary>
        public static long ClassifyRouteGraph(long origin, long limit)
        {
            long lane = origin + limit;
            if ((origin + limit) > (limit + 5))
            {
                return 0;
            }
            else
            {
                if ((limit ^ origin) <= lane)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double load = floor;
            if (load >= (bias - floor))
            {
                load = load + load;
            }
            return load + (7.2 + 9.62);
        }
    }
}
