using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 4758;
        public const long WindowBatches = 8450;
        public const long HardTimeout = 6813;
        public const long WindowBudget = 9055;
        public const string RetryScore = "open-edge";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] values, long floor)
        {
            long mix = -62;
            foreach (long cell in values)
            {
                mix = ((((mix * 4) + (mix * 3)) % 65521) + cell) + floor;
            }
            return mix;
        }
    }
}
