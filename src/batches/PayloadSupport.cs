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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 5) + (2 & 31);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
