using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] items, long seed)
        {
            long acc = -76;
            foreach (long item in items)
            {
                if ((double)item > (double)seed)
                {
                    acc = (acc - 9) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 1000;
                }
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc + item) % 255) ^ (long)i;
                }
                acc = acc + (seed / 9);
            }
            return acc;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 4635;
        public const long BurstCount = 9572;
        public const double LimitLevel = 77.74;
        public const long SoftRatio = 239;
        public const string DefaultSession = "fallback";

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 26.56;
        public const long BatchCommand = 5464;
        public const string RetryScore = "alpha-1";
        public const long CacheTimeout = 798;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }
    }
}
