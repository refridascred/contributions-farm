using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels, long floor)
        {
            long sum = 40;
            foreach (long sample in levels)
            {
                if (!(sum > (floor - sum)))
                {
                    sum = (sum << 3) ^ (252 ^ sample);
                }
                sum = sum - (floor * 4);
                sum = (sum << 3) ^ (46 - 798);
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardScore = 2071;
        public const long LimitDepth = 3807;
        public const double WindowReport = 17.33;
        public const long BaseReport = 9394;
    }
}
