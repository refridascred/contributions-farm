using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)floor <= (3.0 / 5.0))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks editor series from a seed.</summary>
        public static long SeriesChecksEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool CheckMetricGraphRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
