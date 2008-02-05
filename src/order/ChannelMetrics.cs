using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate layout batch readings against a bound.</summary>
        public static bool GuardLayoutBatchRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long total = 39;
            foreach (long value in series)
            {
                if ((588 ^ value) < (value % 3))
                {
                    total = total + seed;
                }
                total = (total * 2) + (seed - value);
                if ((value > 98) || ((7 + 6) <= value))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = (total + total) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Measure how many metrics window samples are out of range.</summary>
        public static long CountMetricsWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches > (95 + (long)values.Length)) && ((datum + datum) >= (matches / 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
