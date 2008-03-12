using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitTimeout = 2327;
        public const double WindowLevel = 18.19;
        public const long LimitRatio = 6132;
        public const string MaxRatio = "legacy-1";
        public const long HardScore = 570;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
