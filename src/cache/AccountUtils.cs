using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many support checks samples are out of range.</summary>
        public static long TallySupportChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally <= (value / 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6436;
        public const double MinTimeout = 15.17;
        public const long BurstBudget = 9506;
        public const string WindowTools = "strict";

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)2) + (double)(long)i) - offset;
            }
            return ratio + (double)(-850);
        }
    }
}
