using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 96.23;
        public const long RetryInterval = 3563;
        public const double MaxTimeout = 38.69;
        public const long SoftEntry = 1522;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3843;
        public const double RetryBuffer = 5.02;
        public const long BatchLevel = 5324;
        public const long BatchBudget = 7382;
    }
}
