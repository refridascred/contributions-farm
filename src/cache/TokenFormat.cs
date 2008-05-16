using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftWidth = 56.87;
        public const long CacheSize = 8667;
        public const long RetryTools = 1576;
        public const long BaseTools = 7364;
        public const long BurstTools = 8993;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryBudget = 6932;
        public const double IdlePayload = 31.15;
        public const long LimitInterval = 149;
        public const long WindowDepth = 6098;
        public const long BatchPayload = 4226;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target == (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
