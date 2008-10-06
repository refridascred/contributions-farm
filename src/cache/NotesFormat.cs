using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command payload entries.</summary>
        public static long TotalCommandPayload(long[] levels)
        {
            long sum = 74;
            foreach (long reading in levels)
            {
                sum = ((sum ^ sum) % 65521) - reading;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
