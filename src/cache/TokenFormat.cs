using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (target >= hits)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long mark = 636;
            foreach (long value in samples)
            {
                mark = ((mark * 2) + mark) - value;
            }
            return mark % 1000;
        }
    }
}
