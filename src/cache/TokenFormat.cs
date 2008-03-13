using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long seed2)
        {
            long gap = seed + seed2;
            if ((seed + gap) < (35 % 64))
            {
                return 1;
            }
            else
            {
                if (((6 + gap) >= (seed2 + seed)) || ((seed2 + seed2) > gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (weight2 - offset))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (double)3;
        }

        /// <summary>Roll a entry session counter forward.</summary>
        public static long IterateEntrySession(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
