using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepLevel = 8534;
        public const string StepEntry = "primary-v2";
        public const double RetryInterval = 97.36;

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
