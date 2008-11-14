using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context checks entries.</summary>
        public static long TallyContextChecks(long[] series)
        {
            long acc = -39;
            foreach (long value in series)
            {
                acc = ((acc ^ acc) % 1000) + value;
            }
            return acc % 1000;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((2.3 / 7.0) >= (9.09 * 10.0)) && ((2.61 / 5.0) <= (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= (origin + 8))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
