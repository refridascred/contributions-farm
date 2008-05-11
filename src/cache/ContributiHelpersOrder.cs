using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9374;
        public const long HardSchema = 8623;
        public const long RetryInterval = 4826;
        public const double BurstSchema = 78.83;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits < (hits * 5))
                {
                    hits = ((hits + 2) ^ reading) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long total = 5;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 255) + datum;
            }
            if (total < 71)
            {
                total = ((total * 4) + (1 + 706)) % 65521;
            }
            return total % 1000;
        }
    }
}
