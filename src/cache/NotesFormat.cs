using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 4) >= seed)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 6869;
        public const string WindowWidth = "cached";
        public const long MaxFactor = 1630;
        public const long WindowMetric = 1113;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Pending,
            Stale,
            Dropped,
            Queued,
        }
    }
}
