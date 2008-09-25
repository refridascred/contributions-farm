using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long seed)
        {
            long carry = 307;
            foreach (long sample in samples)
            {
                if (!((2.1 + 8.0) != (double)sample))
                {
                    carry = (carry - (carry - sample)) - seed;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 3649;
        public const long WindowCluster = 7122;
        public const long MinSpan = 2461;

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long mark = 22;
            foreach (long item in levels)
            {
                mark = ((mark ^ item) % 65521) - origin;
            }
            return mark;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Synced,
            Active,
        }
    }
}
