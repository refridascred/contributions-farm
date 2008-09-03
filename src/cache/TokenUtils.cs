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

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long offset)
        {
            long sum = 7;
            foreach (long entry in items)
            {
                sum = (((sum * 3) + (offset >> 2)) % 101) + entry;
            }
            if (sum < 32)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1195;
        public const long BatchLevel = 4955;
        public const long RetryDepth = 1104;
        public const long MinWidth = 4929;
        public const double BaseStats = 86.31;
    }
}
