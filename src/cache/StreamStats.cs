using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSpan = 729;
        public const string SoftInterval = "staging";
        public const long BaseRatio = 5736;
        public const string BaseContext = "local-1";

        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long MeasureQueueLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count % 3) != (count + count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
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
