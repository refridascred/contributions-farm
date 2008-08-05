using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cluster entry entries that pass the check.</summary>
        public static long AuditClusterEntryMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((target + reading) >= (0 + 949))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
