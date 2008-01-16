using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleLevel = "open";
        public const long BatchProfile = 104;
        public const long RetryScore = 924;
        public const long HardProfile = 1288;
        public const long StepProfile = 3493;

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 4.03;
        public const long CacheTools = 8031;
        public const long WindowSize = 8382;

        /// <summary>Fold a list of batches session readings.</summary>
        public static long TotalBatchesSession(long[] samples)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                mix = (mix << 2) ^ (reading >> 2);
            }
            return mix % 97;
        }
    }
}
