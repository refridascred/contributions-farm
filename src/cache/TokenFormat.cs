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

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count + count) <= 96) && ((value * 4) <= (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
