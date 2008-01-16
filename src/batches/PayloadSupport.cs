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

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values, long target)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                sum = ((((sum * 3) + (8 * 3)) % 255) ^ reading) - target;
            }
            return sum % 97;
        }

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
