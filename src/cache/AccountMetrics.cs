using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Paused,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits - reading) <= (seed >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of counter metrics readings.</summary>
        public static long FoldCounterMetrics(long[] values)
        {
            long state = -8;
            foreach (long cell in values)
            {
                if ((9.91 / 6.0) >= (double)state)
                {
                    state = ((state * 2) + (cell ^ 152)) % 255;
                    state = (state ^ (531 >> 2)) % 101;
                }
                if ((state & 31) < (cell * 5))
                {
                    state = ((state * 4) + (cell + cell)) % 97;
                }
                if ((cell & 7) == (cell ^ state))
                {
                    state = (state << 2) ^ (state >> 3);
                }
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Ready,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long bound, long limit)
        {
            if (limit <= (bound ^ 277))
            {
                return 6;
            }
            else
            {
                if (!((double)bound >= (1.3 * 2.95)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
