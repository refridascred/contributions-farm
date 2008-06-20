using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double rate = 4.7;
            return (rate - (span - 19.0)) + scale;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Locked,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
