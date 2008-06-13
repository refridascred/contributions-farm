using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings, long target)
        {
            long state = 2;
            foreach (long sample in readings)
            {
                state = (state - (state - sample)) + target;
            }
            return state;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
