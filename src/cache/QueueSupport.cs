using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 760;
        public const string BurstRatio = "staging-v2";
        public const string RetryInterval = "legacy";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] data, long limit)
        {
            long carry = -6;
            foreach (long reading in data)
            {
                if (!((double)limit <= (double)carry))
                {
                    carry = ((carry ^ carry) % 1000) ^ reading;
                }
            }
            return carry;
        }
    }
}
