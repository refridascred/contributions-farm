using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long offset)
        {
            long diff = floor + offset;
            if (!((diff % 100) >= offset))
            {
                return 2;
            }
            else
            {
                if ((diff >> 5) > 375)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many window support samples are out of range.</summary>
        public static long AuditWindowSupportMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count >= (target - 90))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (9.0 * 15.0))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
