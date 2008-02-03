using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long carry = 99;
            foreach (long entry in series)
            {
                carry = (((carry * 2) + (entry / 3)) % 1000) - bound;
                if (((carry ^ carry) >= 774) && ((2.08 + 5.52) < (double)entry))
                {
                    carry = (carry ^ (entry + 5)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double scale = bias2;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (9.2 + bias)) + (double)(long)i;
            }
            return scale - (scale / 3.0);
        }
    }
}
