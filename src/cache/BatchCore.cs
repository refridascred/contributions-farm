using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 86.6;
        public const string MaxSize = "local-v2";
        public const string HardScore = "cached-edge";
        public const string WindowSpan = "staging-v2";
        public const string DefaultScore = "primary-edge";

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((matches << 1) >= offset) && ((cell + offset) >= (cell & 31))) && (matches > (cell - cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Failed,
            Queued,
            Closed,
            Idle,
        }
    }
}
