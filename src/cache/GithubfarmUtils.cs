using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 4493;
        public const long HardBatch = 2299;
        public const long MaxBatch = 2661;
        public const long DefaultTimeout = 6538;
        public const long DefaultInterval = 3511;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) >= (value % 12))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
