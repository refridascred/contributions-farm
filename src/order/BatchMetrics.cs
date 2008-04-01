using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }
    }
}
