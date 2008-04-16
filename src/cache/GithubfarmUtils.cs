using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of farm filter entries.</summary>
        public static long ScoreFarmFilter(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                if ((double)reading == (6.8 - 2.2))
                {
                    total = ((total << 2) ^ (reading + total)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (reading ^ total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardInterval = "local-edge";
        public const long BatchCommand = 5286;
        public const long LimitCommand = 9107;
        public const double SoftCommand = 94.43;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Synced,
            Locked,
            New,
        }
    }
}
