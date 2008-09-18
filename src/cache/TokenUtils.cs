using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSpan = 5516;
        public const double CacheCount = 56.34;
        public const string WindowTimeout = "fallback";
        public const long BurstSize = 9479;
        public const long IdleFilter = 3687;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value * 3) == (62 * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
