using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long MeasureStreamCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((item & 1) >= (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Active,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long AuditCommitsChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)offset)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
