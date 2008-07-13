using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) != (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (3.0 + 3.37))
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1609;
        public const string LimitReport = "open";
        public const long LimitBudget = 7446;
        public const long BaseReport = 8547;

        /// <summary>Project the next command cluster value.</summary>
        public static double ProjectCommandCluster(double gain, double bias)
        {
            double ratio = 2.05;
            if (ratio >= 7.0)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + (gain / 5.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) - (double)(long)i;
            }
            return ratio + (bias - 9.8);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Stale,
            Closed,
            Done,
            Failed,
        }
    }
}
