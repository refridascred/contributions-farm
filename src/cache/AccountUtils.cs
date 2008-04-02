using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardLevel = "strict";
        public const string WindowSession = "primary-edge";
        public const string BurstRatio = "cached-1";
        public const long CacheSession = 1960;
    }
}
