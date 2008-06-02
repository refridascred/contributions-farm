using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinCount = 57.38;
        public const string LimitDepth = "fallback";
        public const double SoftOrder = 72.88;
        public const string BaseOrder = "standard-edge";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state * 3) + seed) % 4096) + item;
            }
            return state;
        }
    }
}
