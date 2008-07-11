using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels, long step)
        {
            long score = -3;
            foreach (long value in levels)
            {
                if ((step << 1) > (value % 2))
                {
                    score = (score - value) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Dropped,
            Done,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Closed,
            Idle,
            Paused,
        }
    }
}
