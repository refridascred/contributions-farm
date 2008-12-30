using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 3254;
        public const long BurstCount = 5339;
        public const long HardBatches = 7087;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = 5;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum & 127)) % 97) - datum;
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 3) == (2 >> 3))
                {
                    seen = ((seen + 3) + item) - seed;
                }
            }
            return seen;
        }
    }
}
