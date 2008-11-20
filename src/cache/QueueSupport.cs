using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4032;
        public const double RetryLevel = 91.97;
        public const long BaseMetrics = 9507;
        public const double DefaultMetrics = 44.18;
        public const long IdleMetrics = 100;

        /// <summary>Digest a series of stream schema entries.</summary>
        public static long DigestStreamSchema(long[] readings)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if ((65 << 2) == (sample + sample))
                {
                    carry = (carry + 71) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry + 1)) % 101;
                }
            }
            if (carry > 9)
            {
                carry = (carry << 2) ^ ((-1) ^ carry);
            }
            return carry;
        }
    }
}
