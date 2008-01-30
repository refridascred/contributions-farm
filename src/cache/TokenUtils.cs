using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long ScoreSessionAlready(long[] levels, long offset)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result - offset) % 1000) - value;
            }
            if (result < (-3))
            {
                result = ((result * 4) + 764) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Queued,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Roll a format batches counter forward.</summary>
        public static long RollFormatBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark << 3) ^ (seed % 3)) % 255;
                mark = ((mark * 3) + (mark << 3)) % 101;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
