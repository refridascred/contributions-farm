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

        /// <summary>Define support limits and defaults.</summary>
        public const double HardFactor = 41.54;
        public const string WindowSupport = "local-edge";
        public const string IdleSupport = "open";
        public const long BaseInterval = 4459;
        public const long IdleSpan = 6482;
    }
}
