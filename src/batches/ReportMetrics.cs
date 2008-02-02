using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)890 == (double)target) && ((target + matches) < target))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (acc ^ acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(mark <= (bound << 3)))
                {
                    mark = ((mark * 4) + (bound - bound)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
