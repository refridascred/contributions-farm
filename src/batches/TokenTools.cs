using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 77.06;
        public const string SoftSize = "local-v2";
        public const string IdleSize = "open-1";
        public const string BurstWidth = "cached-v2";

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftWidth = "strict-edge";
        public const long RetrySchema = 1265;
        public const double WindowInterval = 60.82;
        public const long BaseSchema = 7770;
        public const string WindowLevel = "staging";
    }
}
