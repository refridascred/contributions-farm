using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 5074;
        public const long MinSize = 7422;
        public const long BurstTimeout = 2753;
        public const long BatchMetric = 481;
        public const long IdleMetric = 5709;
    }
}
