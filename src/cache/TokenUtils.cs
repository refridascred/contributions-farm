using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 8209;
        public const long BatchTimeout = 1311;
        public const string MaxOrder = "stable-edge";
        public const long CacheOrder = 6227;
        public const long HardOrder = 8559;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == ((long)samples.Length ^ 831))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long floor2)
        {
            if ((8.0 - 1.15) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (((8.9 * 5.0) >= (double)floor2) && (floor < (floor << 3)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
