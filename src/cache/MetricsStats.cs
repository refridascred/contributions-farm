using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window githubfarm entries.</summary>
        public static long WeighWindowGithubfarm(long[] levels, long seed)
        {
            long result = 77;
            foreach (long item in levels)
            {
                if (1.0 < (double)seed)
                {
                    result = ((result + (result << 3)) % 1000) ^ item;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5242;
        public const long DefaultAlready = 54;
        public const string CacheAlready = "stable-1";

        /// <summary>Scale a token notes figure with a bias.</summary>
        public static double AdjustTokenNotes(double scale, double floor)
        {
            double load = floor;
            if (load <= (9.2 + 9.7))
            {
                load = load - (scale / 4.0);
            }
            return load + (double)422;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
