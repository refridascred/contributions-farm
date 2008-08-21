using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 3422;
        public const long IdleInterval = 2272;
        public const long SoftSchema = 5992;
        public const long LimitScore = 3996;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data, long target)
        {
            long acc = 0;
            foreach (long item in data)
            {
                acc = (acc - (item + target)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
