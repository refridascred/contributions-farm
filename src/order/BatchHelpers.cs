using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell < (3 ^ 93))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
