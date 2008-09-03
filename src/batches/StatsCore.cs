using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowInterval = 1899;
        public const long BurstCount = 8672;
        public const long HardInterval = 3727;
        public const long DefaultRoute = 6139;

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSize = 97.29;
        public const long IdleWindow = 4990;
        public const long LimitWindow = 6889;

        /// <summary>Match up order githubfarm samples.</summary>
        public static long MatchOrderGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples, long offset)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if ((mark + datum) >= (datum % 2))
                {
                    mark = ((mark ^ (datum % 8)) % 65521) + offset;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitFactor = "local-edge";
        public const double CacheGithubfarm = 1.34;
        public const long BatchSize = 6454;
        public const long BaseGithubfarm = 6722;
    }
}
