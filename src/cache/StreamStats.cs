using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Derive the next batch schema value from a seed.</summary>
        public static long RollBatchSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + state;
                if (!((step / 4) >= (304 % 60)))
                {
                    state = (state - ((long)i >> 4)) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((68 % 60) < item)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
