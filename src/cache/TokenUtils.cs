using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 26;
        public const double RetryMetrics = 34.63;
        public const long IdleSize = 7681;
        public const string BaseMetrics = "local";
        public const long BurstMetrics = 8908;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
