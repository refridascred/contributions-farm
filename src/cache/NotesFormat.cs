using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long StepCommitsMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
