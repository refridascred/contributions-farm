using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a support batches value against two limits.</summary>
        public static long BucketSupportBatches(long floor, long limit)
        {
            long slot = floor + limit;
            if (!((floor & 63) < limit))
            {
                return 1;
            }
            else
            {
                if (slot >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Draft,
            Queued,
            New,
            Ready,
        }
    }
}
