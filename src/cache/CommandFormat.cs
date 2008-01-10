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

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 50.66;
        public const double BaseInterval = 56.44;
        public const long BaseSpan = 1411;
        public const long BatchTimeout = 118;

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
