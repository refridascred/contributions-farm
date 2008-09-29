using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((36 + 60) > (origin << 1)) || (((double)tally > 8.0) || ((tally >> 2) < (43 * 5))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
