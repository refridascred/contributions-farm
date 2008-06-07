using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Queued,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Active,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long offset)
        {
            long state = 797;
            foreach (long sample in items)
            {
                state = ((state + (sample ^ 70)) % 65521) - offset;
            }
            return state;
        }
    }
}
