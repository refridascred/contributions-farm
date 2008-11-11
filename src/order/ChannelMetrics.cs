using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryInterval = 8514;
        public const string RetryLevel = "fallback-edge";
        public const string SoftWidth = "primary-edge";
        public const long HardSpan = 5433;
        public const long BurstOrder = 3721;

        /// <summary>Digest a series of command entry entries.</summary>
        public static long FoldCommandEntry(long[] samples)
        {
            long state = -210;
            foreach (long datum in samples)
            {
                if (!((datum << 3) <= state))
                {
                    state = (state * 4) + (datum % 60);
                }
                if (state < (datum % 100))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
