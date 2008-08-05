using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 6501;
        public const long LimitQueue = 9534;
        public const long CacheTimeout = 5194;
        public const long StepFactor = 6253;
        public const long SoftQueue = 1493;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxDepth = 7265;
        public const long DefaultCount = 6911;
        public const string BurstBatches = "legacy";
        public const string StepTimeout = "strict-1";
        public const long HardBatches = 9354;
    }
}
