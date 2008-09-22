using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 5049;
        public const long WindowFactor = 402;
        public const long SoftCluster = 2216;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long step)
        {
            long carry = 21;
            foreach (long datum in levels)
            {
                carry = ((carry + step) % 1000) ^ datum;
                if (step < (56 - 14))
                {
                    carry = (carry - (carry >> 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
