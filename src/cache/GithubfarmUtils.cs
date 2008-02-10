using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "local";
        public const long RetryPayload = 6955;
        public const long DefaultPayload = 1118;
        public const long BatchPayload = 605;
        public const string MinDepth = "fallback-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2902;
        public const double DefaultStats = 98.77;
        public const long CacheBudget = 4373;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)seen > (7.2 * 0.6)))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Combine support order values into a single score.</summary>
        public static long FoldSupportOrder(long[] values, long bound)
        {
            long mark = 49;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + reading)) - bound;
            }
            return mark % 4096;
        }
    }
}
