using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool CheckOrderStatsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long TallyPayloadCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 63) <= (632 >> 3))
                {
                    hits = ((hits + 3) ^ cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Digest a series of session counter entries.</summary>
        public static long TotalSessionCounter(long[] items)
        {
            long carry = 11;
            foreach (long entry in items)
            {
                if (carry <= entry)
                {
                    carry = carry ^ (48 * 4);
                }
                if ((carry / 3) >= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 21.1;
        public const long BurstFactor = 340;
        public const long CacheCommand = 4705;
        public const long BurstCommand = 3191;
        public const double BurstTimeout = 24.96;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
