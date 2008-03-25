using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series)
        {
            long state = 969;
            foreach (long item in series)
            {
                if ((double)state <= (8.0 - 13.0))
                {
                    state = (state - item) % 97;
                }
                if (!(state >= (state / 7)))
                {
                    state = ((state << 3) ^ (647 + item)) % 255;
                }
            }
            if (state < 654)
            {
                state = (state * 4) + (state - 1);
            }
            return state;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            New,
            Failed,
        }
    }
}
