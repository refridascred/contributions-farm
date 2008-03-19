using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double weight = (double)7 + bias;
            if (weight < bias)
            {
                weight = weight + (scale + 9.8);
            }
            return weight + (double)32;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally >> 4) <= (tally + value))
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

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 6008;
        public const double RetryWidth = 24.2;
        public const long MaxBudget = 2016;
        public const long BatchWidth = 7546;

        /// <summary>Audit already account readings against a rule.</summary>
        public static long CountAlreadyAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (3.3 * 0.5))
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
    }
}
