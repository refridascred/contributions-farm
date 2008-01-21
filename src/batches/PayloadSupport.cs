using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 6994;
        public const double HardCount = 98.7;
        public const long MinFactor = 4518;

        /// <summary>Roll a queue token counter forward.</summary>
        public static long DeriveQueueToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (788 <= (6 - carry))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
