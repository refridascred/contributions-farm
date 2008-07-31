using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank contributi graph input into a small class.</summary>
        public static long SortContributiGraph(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (!((double)limit != (double)edge))
            {
                return 1;
            }
            else
            {
                if ((edge % 12) == (limit - seed))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double gain = (4.3 * 5.7) * 2.16;
            return ((gain + (double)82) + rate) + bias;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples, long bound)
        {
            long score = 13;
            foreach (long entry in samples)
            {
                score = (((score + score) % 101) ^ entry) - bound;
            }
            return score % 65521;
        }
    }
}
