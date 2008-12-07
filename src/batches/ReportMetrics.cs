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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            New,
            Closed,
            Pending,
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
