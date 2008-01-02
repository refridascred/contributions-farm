using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate order githubfarm readings against a bound.</summary>
        public static bool VerifyOrderGithubfarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 70.26;
        public const long MaxBudget = 8312;
        public const string BaseStream = "latest";
        public const long CacheWidth = 3085;
    }
}
