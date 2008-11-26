using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            if ((double)limit > (8.77 * 0.9))
            {
                return 7;
            }
            else
            {
                if ((limit & 15) <= (869 << 1))
                {
                    return 1;
                }
                else
                {
                    if (((9 - limit) >= origin) || ((limit * 4) <= (limit % 16)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Idle,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Stale,
            Queued,
            Closed,
        }
    }
}
