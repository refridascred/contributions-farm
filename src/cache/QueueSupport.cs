using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double StepWidth = 36.96;
        public const long BatchOrder = 3206;
        public const long HardInterval = 4777;
        public const long DefaultOrder = 9143;
        public const string StepSize = "fallback-edge";

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCount = 78.76;
        public const long SoftCommits = 197;
        public const string IdleCommits = "staging-v2";
        public const long RetryCommits = 8832;
        public const double DefaultCommits = 40.85;
    }
}
