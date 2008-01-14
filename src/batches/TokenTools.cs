using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 3539;
        public const double CacheTimeout = 89.07;
        public const long MinMetrics = 9104;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long acc = 46;
            foreach (long entry in values)
            {
                acc = ((acc * 5) + (entry >> 3)) % 65521;
            }
            if (acc > 324)
            {
                acc = (acc - (184 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long anchor = 94;
            foreach (long cell in readings)
            {
                anchor = (((anchor - (anchor % 10)) % 1000) + cell) + origin;
            }
            return anchor;
        }
    }
}
