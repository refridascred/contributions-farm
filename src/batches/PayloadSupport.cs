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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheFactor = 8915;
        public const long BaseCluster = 6488;
        public const long DefaultBudget = 3820;
    }
}
