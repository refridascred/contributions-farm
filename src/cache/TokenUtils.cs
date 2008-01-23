using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (offset <= seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every report stats entry stays within the limit.</summary>
        public static bool ValidateReportStatsRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
