using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 7981;
        public const double RetryScore = 15.15;
        public const long HardContext = 5968;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + sum) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
