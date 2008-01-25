using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 9169;
        public const double BatchContext = 50.13;
        public const long LimitContext = 503;
        public const long HardContext = 1946;
        public const long LimitScore = 6644;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 1592;
        public const double BatchBudget = 69.93;
        public const string WindowQueue = "staging";
        public const long BaseQueue = 9765;
        public const long BatchQueue = 3214;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "legacy-1";
        public const long CacheRatio = 1930;
        public const double RetryInterval = 24.55;
        public const string DefaultInterval = "legacy-edge";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "staging-v2";
        public const string WindowBatches = "staging-1";
        public const double StepLevel = 74.66;
        public const string StepBatches = "fallback";
    }
}
