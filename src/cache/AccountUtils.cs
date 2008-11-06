using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                carry = ((carry ^ (carry % 97)) % 4096) - value;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally + tally) <= (tally >> 3)) && (origin < cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
