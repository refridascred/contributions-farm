using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "latest-1";
        public const string SoftStream = "fallback-1";
        public const long RetryDepth = 995;
        public const long HardSpan = 7736;
    }
}
