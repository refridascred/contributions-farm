using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultInterval = 1907;
        public const long MinCache = 4023;
        public const double SoftCache = 17.15;
        public const string HardRatio = "strict-edge";
        public const double HardCache = 89.45;

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepFactor = "strict-edge";
        public const double RetryCounter = 6.88;
        public const long BurstSize = 4584;
        public const long MaxCounter = 8477;
        public const double StepScore = 90.35;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long carry = 540;
            foreach (long reading in samples)
            {
                carry = (carry ^ (floor & 63)) ^ reading;
            }
            if (carry < 93)
            {
                carry = (carry * 5) + (carry << 2);
            }
            return carry;
        }
    }
}
