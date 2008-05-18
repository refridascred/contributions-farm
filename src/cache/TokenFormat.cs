using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 44.99;
        public const long RetryCount = 5557;
        public const string MaxBudget = "standard";
        public const long BurstCache = 9215;
        public const double MaxCache = 80.91;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i < 1.0)
                {
                    result = (result + result) % 255;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
