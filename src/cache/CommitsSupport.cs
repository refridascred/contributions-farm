using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a support context sample.</summary>
        public static long LocateSupportContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 5) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
