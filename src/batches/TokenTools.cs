using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count commits schema pairs that satisfy a relation.</summary>
        public static long PairCommitsSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 3) ^ (limit + limit)) % 4096;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
