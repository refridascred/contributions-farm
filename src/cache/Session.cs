using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 764;
        public const double WindowSize = 56.49;
        public const double MinCache = 27.9;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheScore = "alpha-v2";
        public const string BaseTimeout = "cached-v2";
        public const long RetryCount = 7163;
        public const string StepWidth = "primary-edge";
        public const double BaseWindow = 24.47;

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "staging";
        public const long RetryLevel = 2821;
        public const long BurstAccount = 9606;
        public const long MinWidth = 1538;
    }
}
