using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series, long bound)
        {
            long result = 425;
            foreach (long cell in series)
            {
                if ((7.0 * 4.27) > (9.0 * 11.0))
                {
                    result = ((result << 3) ^ cell) - bound;
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 478;
        public const long RetryLevel = 7008;
        public const long DefaultSpan = 4950;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
