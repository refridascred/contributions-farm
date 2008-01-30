using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((99 >> 2) <= (cell & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - (long)i) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
