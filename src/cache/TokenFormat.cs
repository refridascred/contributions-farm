using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)tally <= (double)40))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLevel = 287;
        public const long CacheCount = 473;
        public const double BatchSize = 64.22;
        public const long HardSize = 8495;
        public const long RetryLayout = 4549;
    }
}
