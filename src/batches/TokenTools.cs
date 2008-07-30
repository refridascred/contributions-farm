using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) <= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > bias2)
            {
                bias2 = (bias2 - 15.0) - bias;
            }
            else
            {
                bias2 = bias2 + 5.73;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (double)865;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long total = 9;
            foreach (long value in readings)
            {
                if ((7.45 - 8.3) <= (double)total)
                {
                    total = total + (98 << 2);
                }
                if (value > (value + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
