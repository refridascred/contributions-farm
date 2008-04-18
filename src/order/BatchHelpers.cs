using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values)
        {
            long state = 47;
            foreach (long cell in values)
            {
                state = state - (state + cell);
                state = state - (cell + cell);
            }
            return state;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
