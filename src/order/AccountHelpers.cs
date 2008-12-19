using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryCount = 3194;
        public const long BurstSize = 445;
        public const long CacheMetric = 3639;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -307;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark - mark)) + (long)i;
                }
                if ((mark + entry) >= (mark * 2))
                {
                    mark = mark - (mark + mark);
                    mark = mark ^ mark;
                }
                if ((double)entry == (15.0 / 5.0))
                {
                    mark = (mark + (entry & 63)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 127)) % 65521;
                }
            }
            if (mark < (-6))
            {
                mark = ((mark * 2) + (784 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Active,
            Draft,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) < count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
