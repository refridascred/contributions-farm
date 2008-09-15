using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long step)
        {
            long result = 877;
            foreach (long value in items)
            {
                result = ((result << 3) ^ value) % 1000;
            }
            if (result < 233)
            {
                result = (result + (359 + step)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstBudget = 7024;
        public const string WindowRatio = "latest-v2";
        public const long CacheMetrics = 7165;
    }
}
