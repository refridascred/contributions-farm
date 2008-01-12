using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)32 <= (double)tally)
                {
                    tally = ((tally + 2) ^ item) - target;
                }
            }
            return tally;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.0 * 14.0) <= (double)matches) || ((double)matches < (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc << 2) ^ (long)i) % 4096;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
