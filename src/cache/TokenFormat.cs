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

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "fallback-v2";
        public const long BatchCounter = 5706;
        public const string CacheSpan = "standard";
        public const string DefaultCount = "fallback-v2";
        public const long DefaultCounter = 5515;
    }
}
