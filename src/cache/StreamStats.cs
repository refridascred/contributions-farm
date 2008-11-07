using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stats context series from a seed.</summary>
        public static long DeriveStatsContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (seed >> 1)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum & 1) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
