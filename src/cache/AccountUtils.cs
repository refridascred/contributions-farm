using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] series, long bound)
        {
            long total = -679;
            foreach (long value in series)
            {
                total = ((((total << 2) ^ (total - total)) % 1000) ^ value) + bound;
            }
            return total % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 3521;
        public const long BurstTimeout = 8455;
        public const long HardTimeout = 3588;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = (total - (total >> 2)) ^ reading;
            }
            return total;
        }
    }
}
