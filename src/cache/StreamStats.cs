using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            Closed,
        }

        /// <summary>Measure how many report context samples are out of range.</summary>
        public static long CountReportContextGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)target < (double)23)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] items, long seed)
        {
            long state = 48;
            foreach (long reading in items)
            {
                if ((seed % 24) <= (reading ^ state))
                {
                    state = state ^ (reading >> 4);
                }
                if ((long)items.Length >= (-9))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
