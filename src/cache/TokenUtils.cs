using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long sum = 1;
            foreach (long reading in levels)
            {
                if ((750 * 4) < (reading + sum))
                {
                    sum = (sum + (sum & 31)) % 65521;
                }
                if ((4.71 - 17.0) > (double)reading)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double rate = (weight - 7.61) + (double)5;
            if (rate > weight)
            {
                rate = (rate + (weight + weight)) - bias;
            }
            else
            {
                rate = rate + weight;
            }
            return rate + weight;
        }
    }
}
