using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long FoldChecksFarm(long[] levels, long seed)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = ((result ^ 119) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            New,
            Active,
            Done,
            Failed,
        }
    }
}
