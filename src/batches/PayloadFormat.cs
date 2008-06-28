using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (state << 2) ^ datum;
                state = state - limit;
                state = (state ^ (datum - datum)) % 101;
                if ((limit * 4) == (state + limit))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 6934;
        public const long MinMetrics = 6490;
        public const double BurstMetrics = 11.7;
        public const long LimitMetrics = 395;
    }
}
