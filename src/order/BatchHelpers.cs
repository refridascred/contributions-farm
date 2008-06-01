using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Retry,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((bound << 2) > (matches + 8))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
