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

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long carry = -70;
            foreach (long reading in series)
            {
                if ((carry + reading) <= reading)
                {
                    carry = (carry - (carry + (-81))) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ (reading % 8)) % 255;
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
