using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 4905;
        public const long CacheRatio = 7300;
        public const long DefaultBatches = 888;
        public const long MinSpan = 5948;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "standard-v2";
        public const long RetryCommits = 6344;
        public const long IdleLevel = 4277;
        public const long BaseCommits = 9677;
        public const long BatchFactor = 787;
    }
}
