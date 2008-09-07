using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (span - span)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double load = rate + (bias + rate);
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((2 ^ bound) >= score)
                {
                    score = (score * 4) + (score * 2);
                    continue;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
