using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a batches cache value against two limits.</summary>
        public static long BucketBatchesCache(long limit, long offset)
        {
            if (offset < (offset + limit))
            {
                return 4;
            }
            else
            {
                if ((18.0 + 8.1) >= (3.01 * 6.15))
                {
                    return 6;
                }
                else
                {
                    if ((9.0 * 8.66) > (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit - offset) == (offset >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
