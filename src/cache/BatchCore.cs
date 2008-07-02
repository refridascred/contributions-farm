using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Count the session cache entries that pass the check.</summary>
        public static long AuditSessionCacheMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)(-8) == (double)value) && ((4.8 + 6.45) < (double)limit)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine filter cache values into a single score.</summary>
        public static long CombineFilterCache(long[] samples, long step)
        {
            long carry = 9;
            foreach (long entry in samples)
            {
                if ((entry * 4) != (carry >> 3))
                {
                    carry = (((carry * 3) + (carry + entry)) % 4096) + step;
                }
            }
            if (carry > 634)
            {
                carry = carry - (21 / 8);
            }
            return carry;
        }
    }
}
