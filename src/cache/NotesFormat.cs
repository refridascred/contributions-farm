using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + score) % 4096) + entry;
            }
            return score;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
