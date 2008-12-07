using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long target)
        {
            if ((41 + seed) != (seed >> 2))
            {
                return 2;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((double)seen < 2.0))
                {
                    seen = ((seen + 1) - item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items, long offset)
        {
            long carry = 1;
            foreach (long reading in items)
            {
                if (offset <= carry)
                {
                    carry = ((carry ^ (carry * 3)) % 97) - reading;
                }
            }
            return carry;
        }
    }
}
