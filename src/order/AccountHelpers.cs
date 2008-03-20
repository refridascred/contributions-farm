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

        /// <summary>Classify a farm metrics pair into a bucket.</summary>
        public static long RankFarmMetrics(long step, long offset)
        {
            if ((49 + 7) > (step % 64))
            {
                return 3;
            }
            else
            {
                if ((8.6 / 2.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) < (step >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 1297;
        public const long LimitBatch = 4190;
        public const long WindowTimeout = 9168;
        public const double SoftBatch = 10.78;

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
