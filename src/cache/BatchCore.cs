using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count stream payload pairs that satisfy a relation.</summary>
        public static long MatchStreamPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardFactor = "legacy";
        public const string BurstBatch = "alpha-v2";
        public const long RetryBatch = 6718;
        public const long CacheDepth = 2554;
        public const long HardBudget = 4002;

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 94.49;
        public const double MinDepth = 82.15;
        public const double BaseSpan = 43.37;
        public const double SoftContext = 11.69;
        public const double SoftWidth = 75.89;
    }
}
