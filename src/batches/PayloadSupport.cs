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

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            if (limit < (step << 2))
            {
                return 4;
            }
            else
            {
                if (3 < (step - limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
