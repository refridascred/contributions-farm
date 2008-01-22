using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (value < (value & 127))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels, long bound)
        {
            long mark = 342;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (2 << 3)) + datum) + bound;
            }
            return mark;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
