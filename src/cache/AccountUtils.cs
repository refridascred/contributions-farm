using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of command context readings.</summary>
        public static long OverlapCommandContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
