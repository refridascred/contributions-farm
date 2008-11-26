using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Queued,
            New,
            Ready,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9089;
        public const long BaseSpan = 4319;
        public const long HardFactor = 5016;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
