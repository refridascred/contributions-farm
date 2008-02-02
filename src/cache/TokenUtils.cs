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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples, long origin)
        {
            long state = 840;
            foreach (long entry in samples)
            {
                if (state >= ((-1) + entry))
                {
                    state = ((state << 2) ^ (origin / 9)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
