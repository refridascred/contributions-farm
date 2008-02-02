using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 7110;
        public const long CacheFactor = 377;
        public const string RetryScore = "local-1";
        public const long CacheContributi = 6976;
        public const long SoftContributi = 8667;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long offset)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry << 2) ^ ((long)i + entry)) % 97;
                }
                if ((11 > offset) || (offset > (carry & 15)))
                {
                    carry = ((carry << 2) ^ (entry % 3)) % 65521;
                }
                if (entry < (carry << 3))
                {
                    carry = ((carry * 4) + entry) % 1000;
                }
            }
            if (carry < (-90))
            {
                carry = carry + (carry / 5);
            }
            return carry;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Draft,
            Paused,
            Closed,
            Stale,
        }
    }
}
