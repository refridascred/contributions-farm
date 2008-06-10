using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) == (count & 31))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((item - matches) != (matches - (-969))) && ((item << 2) < (item - item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel token samples.</summary>
        public static long CombineChannelToken(long[] series)
        {
            long state = 99;
            foreach (long reading in series)
            {
                state = (state + 542) % 101;
                state = (state * 3) + (reading * 2);
            }
            return state;
        }
    }
}
