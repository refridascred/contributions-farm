using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7566;
        public const long CacheRatio = 9650;
        public const long DefaultRatio = 2539;
        public const long MaxWidth = 2203;
        public const long RetryCluster = 4628;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + ((long)i - 241)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
