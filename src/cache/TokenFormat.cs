using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit - cur) < origin)
            {
                return 2;
            }
            else
            {
                if ((1.3 / 6.0) != (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 4528;
        public const long HardEditor = 1069;
        public const long RetryTimeout = 4558;
    }
}
