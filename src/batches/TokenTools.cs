using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two farm notes measurements.</summary>
        public static double AdjustFarmNotes(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > bias)
            {
                rate2 = rate2 - 19.0;
            }
            return rate2 - (bias + rate);
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double mean = (double)(88 / 3);
            if (mean <= 4.0)
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean - (double)324;
            }
            return mean - bias;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i > (step + 95))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
