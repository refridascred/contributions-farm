using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long floor)
        {
            if ((floor - floor) > offset)
            {
                return 7;
            }
            else
            {
                if (offset <= (floor / 7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "fallback-v2";
        public const long BatchCounter = 5706;
        public const string CacheSpan = "standard";
        public const string DefaultCount = "fallback-v2";
        public const long DefaultCounter = 5515;
    }
}
