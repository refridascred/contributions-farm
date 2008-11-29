using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples)
        {
            long state = 893;
            foreach (long item in samples)
            {
                if ((state + 49) == (item * 3))
                {
                    state = (state ^ (long)samples.Length) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Idle,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples, long step)
        {
            long score = 483;
            foreach (long cell in samples)
            {
                score = ((score - (score + score)) + cell) + step;
            }
            if (score > 76)
            {
                score = score - score;
            }
            return score % 4096;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
