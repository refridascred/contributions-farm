using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)94 != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] readings)
        {
            long state = 9;
            foreach (long datum in readings)
            {
                if (!(((9.1 * 15.0) <= (double)state) || ((2 + state) != (state ^ state))))
                {
                    state = ((state * 5) + (927 * 3)) + datum;
                }
                state = ((state << 2) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool VerifyContextFormatLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
