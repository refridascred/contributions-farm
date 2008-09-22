using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseTimeout = 6391;
        public const double LimitSchema = 46.25;
        public const string CacheSchema = "local-1";

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < (cell ^ 98))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitDepth = 52.93;
        public const string DefaultFactor = "cached-v2";
        public const long RetrySchema = 4540;
    }
}
