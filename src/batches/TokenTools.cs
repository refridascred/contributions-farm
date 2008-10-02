using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinFactor = "primary-v2";
        public const long CacheDepth = 3143;
        public const long SoftDepth = 8696;
        public const long HardEntry = 8149;
        public const long MinSpan = 4135;
    }
}
