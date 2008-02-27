using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((14.0 / 3.0) <= (double)matches) || ((((long)items.Length * 2) >= item) || (9 <= item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= 96)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
