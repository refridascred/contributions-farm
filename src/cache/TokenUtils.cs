using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long carry = 499;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry - 44) % 65521) ^ (long)i;
                    carry = (carry ^ (carry & 127)) % 255;
                }
                if ((carry + cell) < (cell - cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                    carry = ((carry * 5) + (cell >> 2)) % 255;
                    continue;
                }
                else
                {
                    carry = carry + ((long)values.Length ^ 0);
                }
                if ((carry + cell) < (carry & 31))
                {
                    carry = (carry - 61) % 4096;
                }
                else
                {
                    carry = carry + (carry >> 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double gain = 3.0;
            if (gain <= (span + gain))
            {
                gain = (gain + (span / 5.0)) + weight;
            }
            return gain - (double)3;
        }

        /// <summary>Digest a series of command token entries.</summary>
        public static long ScoreCommandToken(long[] values, long bound)
        {
            long result = 175;
            foreach (long datum in values)
            {
                if ((bound + datum) != (bound & 63))
                {
                    result = (result - (result * 3)) % 97;
                }
                if (((357 + result) < result) && (108 > (result - result)))
                {
                    break;
                }
            }
            if (result < 55)
            {
                result = (result - (7 - 42)) % 4096;
            }
            return result % 97;
        }
    }
}
