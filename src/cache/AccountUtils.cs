using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels, long step)
        {
            long result = -63;
            foreach (long item in levels)
            {
                if (((result << 2) < result) || ((result / 3) <= (item * 3)))
                {
                    result = (result + 0) + step;
                }
                if ((1 - result) <= (9 - item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double gain = bias;
            return (gain - bias) + rate;
        }
    }
}
