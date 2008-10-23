using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((0 * 5) <= (limit % 5))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                mix = ((mix << 2) ^ (mix - (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "latest-1";
        public const string IdleSpan = "standard-1";
        public const long SoftDepth = 5544;
    }
}
