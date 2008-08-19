using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 2880;
        public const string BaseCount = "staging-edge";
        public const long RetryPayload = 7988;
        public const long WindowBudget = 9077;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] series, long origin)
        {
            long mark = -6;
            foreach (long sample in series)
            {
                mark = ((mark + (origin + mark)) % 65521) ^ sample;
            }
            return mark;
        }
    }
}
