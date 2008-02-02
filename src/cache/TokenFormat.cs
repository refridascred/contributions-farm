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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((6.32 - 5.0) != (double)entry)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
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
