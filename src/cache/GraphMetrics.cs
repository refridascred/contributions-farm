using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 206;
            foreach (long datum in items)
            {
                state = state - state;
                for (int i = 0; i < 9; i++)
                {
                    state = (state * 3) + ((long)i & 15);
                }
                state = (state + (datum + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Stale,
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Failed,
            Paused,
            Locked,
            Synced,
        }
    }
}
