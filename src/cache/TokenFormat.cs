using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up window schema samples.</summary>
        public static long PairWindowSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits >> 2) != (cell + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 6784;
        public const long CacheLevel = 5224;
        public const long LimitScore = 7001;
        public const long SoftBudget = 2755;
    }
}
