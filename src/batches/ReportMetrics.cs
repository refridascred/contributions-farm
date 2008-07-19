using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long bound)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                if (state >= (entry - bound))
                {
                    state = (state - entry) % 255;
                }
                else
                {
                    state = (state << 3) ^ (entry + 98);
                }
            }
            if (state < 37)
            {
                state = (state + bound) % 97;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
