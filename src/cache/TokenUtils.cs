using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long bound)
        {
            long result = 591;
            foreach (long value in levels)
            {
                if (!((bound - result) == (result << 2)))
                {
                    result = ((result << 3) ^ (0 * 4)) % 4096;
                }
                result = result ^ (result >> 3);
                result = (result - (bound ^ value)) % 101;
            }
            if (result < 29)
            {
                result = (result - (695 - result)) % 1000;
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2911;
        public const long SoftTimeout = 8686;
        public const long BatchRatio = 7248;
        public const long LimitInterval = 1980;
        public const string RetryBuffer = "strict-edge";
    }
}
