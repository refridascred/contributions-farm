using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches == (5.55 - 11.0))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long FoldOrderStream(long[] readings)
        {
            long carry = 694;
            foreach (long cell in readings)
            {
                if ((carry >> 2) == (cell + carry))
                {
                    carry = (carry << 2) ^ (carry - 16);
                }
                else
                {
                    carry = (carry * 2) + cell;
                }
                if ((79 - cell) >= (13 / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
