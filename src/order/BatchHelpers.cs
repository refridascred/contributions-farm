using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats batches input into a small class.</summary>
        public static long BucketStatsBatches(long seed, long offset)
        {
            long span = seed ^ offset;
            if (seed <= span)
            {
                return 2;
            }
            else
            {
                if ((offset + seed) < (offset + span))
                {
                    return 4;
                }
                else
                {
                    if ((span << 3) < (seed + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Ready,
            Done,
            New,
            Idle,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
