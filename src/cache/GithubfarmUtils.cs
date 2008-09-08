using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 75.14;
        public const string StepWidth = "standard-edge";
        public const long HardOrder = 9415;

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 7395;
        public const double CacheAccount = 42.42;
        public const long SoftAccount = 9624;
        public const long BatchAccount = 2120;
    }
}
