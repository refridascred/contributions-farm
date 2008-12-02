using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank queue filter input into a small class.</summary>
        public static long GradeQueueFilter(long target, long seed)
        {
            if ((seed << 3) <= (seed * 3))
            {
                return 4;
            }
            else
            {
                if (((seed - seed) <= (seed * 2)) && ((44 + seed) != (65 - target)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 59;
            foreach (long item in readings)
            {
                state = (((state << 3) ^ (state % 60)) % 1000) ^ item;
            }
            if (state < 426)
            {
                state = ((state << 2) ^ 8) % 97;
            }
            return state % 65521;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double mean = (floor / 2.0) - (double)456;
            if (mean <= floor)
            {
                mean = (mean + (double)3) - scale;
            }
            else
            {
                mean = mean + (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
