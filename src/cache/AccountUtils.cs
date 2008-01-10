using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "staging-v2";
        public const long WindowProfile = 6571;
        public const long BaseProfile = 1618;

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
