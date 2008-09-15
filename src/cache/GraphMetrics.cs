using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                result = (((result ^ ((long)levels.Length % 12)) % 101) - datum) - limit;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) == (seen + 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}
