using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchRatio = "latest-edge";
        public const double WindowGraph = 54.24;
        public const long RetryGraph = 8053;

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long total = -68;
            foreach (long cell in values)
            {
                total = (((total - (386 - total)) % 97) ^ cell) + limit;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 1159;
        public const double RetryAlready = 8.53;
        public const double BaseAlready = 94.54;
        public const double MinAlready = 65.83;
        public const double RetryDepth = 33.14;

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long AuditWindowCacheGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (datum >> 2)) && ((26 * 2) != (limit % 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
