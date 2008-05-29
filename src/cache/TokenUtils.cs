using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCount = 944;
        public const double CacheCluster = 75.1;
        public const long RetryDepth = 5245;
        public const long BatchCluster = 190;
        public const string IdleBudget = "fallback-1";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < (8.85 * 6.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
