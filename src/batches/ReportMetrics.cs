using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long ClassifyStreamQueue(long target, long offset)
        {
            long delta = target + offset;
            if ((delta & 255) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((delta + (-1)) >= (target + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta >> 4) == (6 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.51 + 6.0) > (double)matches)
                {
                    matches = ((matches + 2) ^ item) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
