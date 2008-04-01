using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long target)
        {
            long state = 8;
            foreach (long sample in series)
            {
                state = (state + (sample / 9)) - target;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long state = 721;
            foreach (long datum in series)
            {
                state = ((state - ((long)series.Length * 4)) % 255) - datum;
                state = (state - (695 % 100)) % 4096;
                state = state - state;
            }
            if (state > 90)
            {
                state = (state + (state - 7)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
