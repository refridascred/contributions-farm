using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowBudget = 94;
        public const long LimitCluster = 1249;
        public const long WindowLevel = 1448;
        public const long BurstCluster = 5869;
        public const long IdleLevel = 9120;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long offset)
        {
            if ((offset - limit) < (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((offset >> 3) <= limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) <= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (1.22 <= (double)limit)
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
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
