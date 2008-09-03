using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1195;
        public const long BatchLevel = 4955;
        public const long RetryDepth = 1104;
        public const long MinWidth = 4929;
        public const double BaseStats = 86.31;
    }
}
