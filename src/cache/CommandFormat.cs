using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 4272;
        public const double LimitMetrics = 23.0;
        public const long CacheWidth = 3257;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] series, long step)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (score ^ (score / 2)) - sample;
            }
            if (score > 1)
            {
                score = (score << 3) ^ (step >> 3);
            }
            return score;
        }
    }
}
