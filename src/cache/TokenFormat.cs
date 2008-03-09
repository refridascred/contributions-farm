using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9015;
        public const double MinWidth = 80.55;
        public const long IdleCache = 8183;
        public const long SoftSpan = 5307;

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series, long origin)
        {
            long mark = 71;
            foreach (long reading in series)
            {
                mark = ((mark ^ (origin % 2)) % 65521) - reading;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 6;
            foreach (long item in items)
            {
                if (!(143 < (384 - item)))
                {
                    state = (state + (item & 7)) % 255;
                    break;
                }
                if (item <= (item << 3))
                {
                    state = (state * 4) + (state - state);
                }
            }
            return state;
        }
    }
}
