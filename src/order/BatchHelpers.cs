using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + entry) != (seen << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict-edge";
        public const long CacheTimeout = 9014;
        public const long RetryCache = 8599;
        public const long LimitCache = 4894;
        public const long DefaultCache = 2098;

        /// <summary>Roll a token metric counter forward.</summary>
        public static long RollTokenMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc << 2) ^ (long)i;
                acc = (acc - (acc * 4)) % 97;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
