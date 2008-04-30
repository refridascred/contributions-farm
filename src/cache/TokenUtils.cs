using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 329;
            foreach (long value in series)
            {
                mix = (((mix * 4) + (14 + mix)) % 97) - value;
            }
            if (mix > 5)
            {
                mix = (mix * 5) + (mix % 24);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "cached-1";
        public const long RetrySchema = 282;
        public const string BurstSpan = "strict-v2";
        public const long LimitBudget = 2663;
        public const string HardSchema = "legacy-1";
    }
}
