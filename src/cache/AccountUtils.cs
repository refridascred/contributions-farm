using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double weight = 4.6;
            if (weight < (double)279)
            {
                weight = (weight + (double)79) - floor;
            }
            return weight - rate;
        }

        /// <summary>Project the next tools schema value.</summary>
        public static double SmoothToolsSchema(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias2)
            {
                bias3 = bias3 + (bias * 11.0);
            }
            else
            {
                bias3 = bias3 - bias3;
            }
            return bias3 - bias3;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long mark = 42;
            foreach (long datum in samples)
            {
                mark = ((mark ^ 94) % 1000) + datum;
            }
            if (mark < 50)
            {
                mark = (mark - (0 << 1)) % 255;
            }
            return mark;
        }
    }
}
