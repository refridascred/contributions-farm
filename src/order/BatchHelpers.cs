using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value << 3) == (value - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
