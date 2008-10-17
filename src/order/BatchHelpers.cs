using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Closed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 100) < (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)184) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (double)70) + (double)(long)i;
            }
            return rate2 - (rate2 / 4.0);
        }
    }
}
