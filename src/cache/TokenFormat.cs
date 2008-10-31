using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6901;
        public const long StepLevel = 3899;
        public const long MaxRatio = 9588;
        public const long BatchInterval = 8415;
        public const double RetryMetrics = 84.3;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "local-1";
        public const double SoftRatio = 73.26;
        public const double StepMetric = 27.03;
    }
}
