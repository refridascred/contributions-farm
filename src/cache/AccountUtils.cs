using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long seed)
        {
            long carry = 608;
            foreach (long reading in readings)
            {
                if ((double)seed <= (11.0 - 8.0))
                {
                    carry = ((carry * 3) + (carry & 7)) ^ reading;
                }
            }
            if (carry < 898)
            {
                carry = (carry - (carry >> 5)) % 97;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(tally > (tally - 6)) || ((double)tally < (2.1 / 8.0)))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double gain2 = floor * 11.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 + (floor * 16.0)) + (double)(long)i) + gain;
            }
            return gain2 + (5.25 / 3.0);
        }
    }
}
