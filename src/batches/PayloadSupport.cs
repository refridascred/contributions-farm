using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5137;
        public const long SoftInterval = 8196;
        public const long CacheStats = 4586;
        public const double BurstStats = 62.28;
        public const double MaxLevel = 90.26;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] samples, long limit)
        {
            long carry = 28;
            foreach (long value in samples)
            {
                if (carry <= (value + limit))
                {
                    carry = carry + 33;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
