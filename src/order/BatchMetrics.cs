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

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 0;
            foreach (long entry in data)
            {
                if (!((entry >> 5) <= (830 + acc)))
                {
                    acc = ((acc * 4) + (acc - entry)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc - (entry >> 1)) % 255;
                }
                if ((double)acc < (8.47 / 3.0))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            return acc % 1000;
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
