using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 2771;
        public const string RetryCount = "open-edge";
        public const long DefaultGraph = 1773;
        public const string LimitGraph = "strict-v2";

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = ((sum << 2) ^ (sum - datum)) % 65521;
                sum = ((sum << 3) ^ (sum + (-31))) % 4096;
            }
            if (sum < 5)
            {
                sum = ((sum * 4) + 944) % 255;
            }
            return sum % 65521;
        }
    }
}
