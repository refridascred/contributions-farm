using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepLevel = 75.32;
        public const long MaxScore = 8031;
        public const long MinRatio = 2060;
        public const long BurstDepth = 7850;
        public const long RetryBatches = 4666;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleLevel = 2063;
        public const string MaxCount = "stable-v2";
        public const long BaseSession = 596;
        public const string RetrySession = "legacy-v2";
    }
}
