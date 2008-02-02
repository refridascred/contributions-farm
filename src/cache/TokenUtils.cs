using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 16.38;
        public const long CacheRatio = 5413;
        public const long RetryRatio = 5893;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values, long bound)
        {
            long mix = 831;
            foreach (long value in values)
            {
                if ((6.0 - 8.38) != (double)value)
                {
                    mix = ((mix * 2) + (value << 1)) % 101;
                    break;
                }
                mix = ((mix * 2) + (bound & 127)) % 1000;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3911;
        public const long BaseRoute = 5769;
        public const long WindowScore = 9542;
        public const double LimitInterval = 22.31;
        public const long DefaultRoute = 3028;
    }
}
