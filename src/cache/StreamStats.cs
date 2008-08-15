using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit stats token readings against a rule.</summary>
        public static long CountStatsTokenHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value / 6) >= (value - value)) && ((207 * 5) < value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Stale,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((2.86 * 4.0) < (double)entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
