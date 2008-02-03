using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double load = 4.6;
            if (load < weight)
            {
                load = load - (span / 7.0);
            }
            return load + (6.42 * 4.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2208;
        public const double HardLevel = 58.98;
        public const long BurstBudget = 1954;
        public const double WindowRoute = 59.38;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)(-28) > (double)limit)
                {
                    tally = (tally + 1) + sample;
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
