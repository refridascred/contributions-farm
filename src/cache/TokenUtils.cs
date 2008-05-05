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

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
