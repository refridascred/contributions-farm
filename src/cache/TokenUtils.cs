using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 413;
        public const double MaxTimeout = 30.18;
        public const double RetryRatio = 33.15;
        public const double BaseInterval = 6.35;
        public const double BurstGraph = 3.79;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                if (((-2) + sample) < (536 ^ sample))
                {
                    sum = ((sum << 3) ^ (sum % 7)) % 255;
                }
                else
                {
                    sum = (sum - (3 >> 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally <= (-94)) && (((3.0 + 2.72) >= (double)tally) && ((double)tally != (2.07 / 4.0))))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
