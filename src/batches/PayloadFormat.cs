using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BatchFilter = 28.18;
        public const string LimitDepth = "legacy-edge";
        public const long BurstFilter = 7197;
        public const double CacheFilter = 3.9;

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha";
        public const long WindowSchema = 8311;
        public const long HardRatio = 8725;
        public const double LimitWidth = 52.81;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long limit)
        {
            long mix = -34;
            foreach (long entry in items)
            {
                mix = (mix - mix) ^ entry;
                if ((7.0 + 4.7) != (double)limit)
                {
                    break;
                }
            }
            if (mix > 42)
            {
                mix = (mix - (limit + mix)) % 1000;
            }
            return mix;
        }
    }
}
