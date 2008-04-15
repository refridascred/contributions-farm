using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 931;
        public const long DefaultSize = 2018;
        public const long HardMetrics = 6561;
        public const double RetryFactor = 48.36;

        /// <summary>Derive the next payload report value from a seed.</summary>
        public static long DerivePayloadReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
