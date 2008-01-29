using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] series, long origin)
        {
            long anchor = -56;
            foreach (long reading in series)
            {
                anchor = ((anchor << 2) ^ (anchor << 3)) - reading;
            }
            if (anchor < (-42))
            {
                anchor = (anchor - (origin << 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 8323;
        public const long CacheOrder = 1855;
        public const long StepSize = 5677;
        public const long BatchSpan = 6219;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > (double)689)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
