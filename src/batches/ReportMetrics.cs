using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long seed2)
        {
            if (seed <= (seed2 + seed2))
            {
                return 2;
            }
            else
            {
                if ((864 & 3) >= (seed2 ^ 7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 7543;
        public const long CacheSize = 2884;
        public const long LimitDepth = 4363;
        public const long RetryLevel = 5834;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
