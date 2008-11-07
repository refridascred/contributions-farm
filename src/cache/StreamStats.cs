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

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                anchor = (anchor ^ (89 << 2)) - reading;
                anchor = anchor - (anchor % 16);
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
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
