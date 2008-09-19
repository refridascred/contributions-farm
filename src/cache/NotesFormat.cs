using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 984;
            foreach (long entry in items)
            {
                if ((double)entry > (6.7 + 5.0))
                {
                    carry = (carry - (0 ^ 9)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "stable";
        public const double CacheSpan = 25.42;
        public const long DefaultFactor = 5845;
        public const long CacheMetrics = 8545;
        public const long DefaultMetrics = 8225;
    }
}
