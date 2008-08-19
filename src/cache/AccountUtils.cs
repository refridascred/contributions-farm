using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((double)floor == (double)417)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (3.21 * 16.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((78 & 127) >= (cell - 85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
