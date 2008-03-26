using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches >= 7.38)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((839 - count) == (count & 7))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels)
        {
            long state = 868;
            foreach (long value in levels)
            {
                if (820 <= state)
                {
                    state = ((state << 3) ^ value) % 255;
                }
                else
                {
                    state = (state * 5) + (state - 141);
                }
            }
            return state;
        }
    }
}
