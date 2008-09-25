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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long limit)
        {
            long state = 797;
            foreach (long item in series)
            {
                if ((item / 7) != (state & 255))
                {
                    state = ((state << 3) ^ (state >> 3)) % 97;
                }
            }
            if (state > (-5))
            {
                state = ((state << 2) ^ limit) % 65521;
            }
            return state % 1000;
        }

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
