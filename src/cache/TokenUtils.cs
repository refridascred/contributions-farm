using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (anchor > (anchor % 97))
                {
                    anchor = anchor + (anchor - value);
                }
            }
            return anchor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheLevel = 61.95;
        public const double LimitEditor = 17.68;
        public const double DefaultEditor = 15.7;
        public const long SoftDepth = 9655;
        public const long WindowSize = 8689;
    }
}
