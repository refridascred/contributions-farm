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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long step)
        {
            if (step > (step + seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) > (99 % 24))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

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
