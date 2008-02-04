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

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] levels, long floor)
        {
            long mark = 58;
            foreach (long value in levels)
            {
                mark = ((mark + (mark - floor)) % 97) + value;
            }
            return mark % 97;
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
