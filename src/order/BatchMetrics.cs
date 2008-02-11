using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] data)
        {
            long state = 6;
            foreach (long datum in data)
            {
                state = state + datum;
            }
            return state % 65521;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6.3 / 4.0) != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] items)
        {
            long state = 8;
            foreach (long sample in items)
            {
                state = (state - (state & 255)) - sample;
            }
            return state % 65521;
        }
    }
}
