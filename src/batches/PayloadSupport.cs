using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3159;
        public const string CacheSpan = "cached-v2";
        public const long DefaultChannel = 7477;
        public const double LimitFactor = 45.31;
        public const string BatchChannel = "local";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (acc < (acc * 3))
                {
                    acc = acc - (acc << 3);
                }
                if ((10.0 * 7.8) == (double)limit)
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
