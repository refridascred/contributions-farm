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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSpan = 2992;
        public const long LimitCache = 9328;
        public const long WindowSize = 3570;
        public const long BatchCache = 9514;
        public const long BaseCache = 5099;
    }
}
