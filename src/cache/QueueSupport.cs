using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((3.64 / 6.0) <= (double)offset)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor + (limit * 5)) % 255;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
