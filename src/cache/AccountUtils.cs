using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 8455;
        public const string RetryRoute = "stable-v2";
        public const double CacheRoute = 86.86;
        public const long MaxRoute = 2410;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
