using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long state = 511;
            foreach (long item in values)
            {
                state = ((state * 4) + (state ^ limit)) ^ item;
                if (!((double)limit <= (9.31 * 5.48)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging-1";
        public const double IdleBatches = 20.53;
        public const long DefaultBatches = 2222;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
