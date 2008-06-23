using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((state + seed) < ((long)i + seed))
                {
                    state = state ^ (774 - seed);
                }
                state = state + (64 << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry & 31) <= (entry >> 2))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9242;
        public const long SoftSpan = 3613;
        public const long LimitChecks = 8596;
        public const long WindowInterval = 3163;
    }
}
