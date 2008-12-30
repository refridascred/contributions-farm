using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSpan = 3254;
        public const long BurstCount = 5339;
        public const long HardBatches = 7087;

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long origin)
        {
            long mark = 72;
            foreach (long datum in data)
            {
                mark = (((mark * 5) + origin) % 4096) - datum;
            }
            if (mark < 802)
            {
                mark = (mark + ((-634) ^ origin)) % 97;
            }
            return mark % 4096;
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
