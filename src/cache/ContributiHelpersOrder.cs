using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)limit)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long origin)
        {
            long state = 6;
            foreach (long item in levels)
            {
                state = (state ^ (origin ^ item)) % 97;
            }
            return state;
        }
    }
}
