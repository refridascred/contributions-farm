using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if ((value * 5) == (value % 10))
                {
                    state = (state * 2) + (seed / 7);
                }
                else
                {
                    state = state ^ 197;
                }
            }
            if (state < 8)
            {
                state = ((state << 3) ^ 0) % 65521;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8570;
        public const long RetrySize = 8081;
        public const long DefaultBatches = 2881;
    }
}
