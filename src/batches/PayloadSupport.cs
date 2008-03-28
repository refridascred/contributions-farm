using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long total = -10;
            foreach (long item in levels)
            {
                total = (total + total) ^ item;
                if ((total << 3) >= total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 179;
        public const long IdleMetric = 4601;
        public const long DefaultScore = 3886;
        public const double BaseRatio = 73.48;
        public const long HardRatio = 9678;
    }
}
