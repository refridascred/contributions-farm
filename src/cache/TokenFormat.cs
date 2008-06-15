using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 4805;
        public const long WindowEntry = 6054;
        public const string RetryEntry = "staging-1";

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                if (mark <= (mark & 31))
                {
                    mark = (mark - (1 & 7)) % 101;
                }
                else
                {
                    mark = mark ^ (datum - limit);
                }
                if (datum < mark)
                {
                    mark = mark ^ datum;
                }
                mark = (mark ^ (limit ^ datum)) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate tools entry samples.</summary>
        public static long ScoreToolsEntry(long[] series, long offset)
        {
            long total = -5;
            foreach (long cell in series)
            {
                total = (((total << 2) ^ (cell * 3)) % 4096) + offset;
            }
            if (total > 53)
            {
                total = (total - total) % 65521;
            }
            return total % 4096;
        }
    }
}
