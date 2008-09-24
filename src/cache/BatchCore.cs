using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitLevel = 2941;
        public const string LimitTimeout = "fallback";
        public const long HardFactor = 9336;
        public const string WindowGraph = "open-edge";
        public const double LimitCount = 55.87;

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 6;
            foreach (long value in readings)
            {
                if (((value - score) > (long)readings.Length) && ((3 * 4) == (value * 3)))
                {
                    score = (score - (value + 772)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
