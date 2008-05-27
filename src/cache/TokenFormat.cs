using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue cluster readings against a rule.</summary>
        public static long TallyQueueClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (618 >= tally)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches & 3) < (92 & 7))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
