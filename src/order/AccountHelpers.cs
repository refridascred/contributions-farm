using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 6970;
        public const long CacheRecord = 9463;
        public const long MaxRecord = 2970;
        public const double BurstRecord = 60.24;

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftCount = "primary-v2";
        public const double WindowTools = 11.78;
        public const long StepTools = 3842;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSize = 5985;
        public const long DefaultContext = 8051;
        public const long BatchContext = 1577;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
