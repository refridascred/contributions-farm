using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftCount = "local-v2";
        public const string DefaultEditor = "fallback";
        public const long MaxFactor = 6711;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
