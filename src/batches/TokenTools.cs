using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) >= datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the schema graph entries that pass the check.</summary>
        public static long CountSchemaGraphMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (seed <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
