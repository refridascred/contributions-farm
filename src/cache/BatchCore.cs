using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Done,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 39.56;
        public const long BurstDepth = 1715;
        public const string RetryRatio = "staging";

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
