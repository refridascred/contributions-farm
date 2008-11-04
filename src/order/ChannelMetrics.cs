using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long result = -9;
            foreach (long datum in items)
            {
                result = (result + (datum % 60)) % 101;
            }
            if (result < 70)
            {
                result = (result ^ (result & 127)) % 65521;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 742;
        public const long DefaultFactor = 13;
        public const double WindowTimeout = 6.89;
        public const double MinCount = 50.22;
    }
}
