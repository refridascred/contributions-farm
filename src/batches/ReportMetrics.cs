using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metrics context samples.</summary>
        public static long FoldMetricsContext(long[] values, long target)
        {
            long state = 10;
            foreach (long entry in values)
            {
                if ((entry >> 2) >= state)
                {
                    state = ((state * 4) + (entry + target)) % 101;
                }
                state = (state - (target + state)) % 255;
            }
            if (state > 9)
            {
                state = (state - (target / 8)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            New,
            Stale,
        }
    }
}
