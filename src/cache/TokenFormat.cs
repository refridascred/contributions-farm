using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 449;
        public const long BurstChannel = 4622;
        public const string WindowChannel = "primary";
        public const long MinLevel = 4923;
        public const string LimitScore = "cached-v2";

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long acc = -5;
            foreach (long datum in items)
            {
                if (!(468 > (acc ^ 2)))
                {
                    acc = (((acc << 3) ^ (acc >> 3)) % 101) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
