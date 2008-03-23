using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 3195;
        public const long WindowLayout = 9820;
        public const string RetryLayout = "alpha-edge";
        public const long MinSpan = 1812;
        public const long BaseLayout = 3889;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
