using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 8218;
        public const string StepSupport = "cached";
        public const long WindowSupport = 7768;
        public const long SoftSupport = 585;
        public const long RetrySupport = 572;

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] series, long target)
        {
            long sum = 43;
            foreach (long item in series)
            {
                if ((double)item > (3.17 - 9.1))
                {
                    sum = ((sum << 3) ^ (4 + sum)) - target;
                }
            }
            return sum % 1000;
        }
    }
}
