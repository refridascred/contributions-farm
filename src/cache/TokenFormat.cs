using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (sum >> 2)) % 101;
                if ((1.2 / 2.0) >= (double)sum)
                {
                    sum = ((sum << 3) ^ (target + sum)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum & 63)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 5; i++)
            {
                rate2 = ((rate2 + (rate2 / 4.0)) + (double)(long)i) - rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (1.8 - 4.0))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
