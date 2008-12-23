using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if ((2.8 / 2.0) < (double)step)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (7.64 * 1.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)step >= (double)496) || ((offset >> 4) >= (13 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long state = 797;
            foreach (long item in levels)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state << 3) ^ (item + state)) % 4096;
            }
            if (state < 36)
            {
                state = (state - 14) % 101;
            }
            return state;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
