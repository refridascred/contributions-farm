using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 9345;
        public const string BaseChecks = "legacy-v2";
        public const long IdleChecks = 4411;

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
