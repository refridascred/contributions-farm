using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long limit2)
        {
            if ((double)limit2 == (3.3 + 8.95))
            {
                return 4;
            }
            else
            {
                if (limit2 >= (limit & 127))
                {
                    return 2;
                }
                else
                {
                    if (!((double)limit2 > (double)89))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 1329;
        public const string HardRecord = "standard-v2";
        public const double BurstRecord = 98.45;
        public const long WindowRecord = 2004;
        public const string CacheRecord = "open";

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
