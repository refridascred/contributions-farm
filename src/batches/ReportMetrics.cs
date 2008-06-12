using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long carry = 85;
            foreach (long datum in series)
            {
                long span = (datum - carry) % 2;
                if ((carry >> 4) <= carry)
                {
                    carry = ((carry << 2) ^ span) % 65521;
                }
                if (62 >= (carry + datum))
                {
                    carry = (carry << 3) ^ (datum * 5);
                }
                if ((carry + carry) != (carry ^ (-550)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long seed)
        {
            long bound = target + seed;
            if (!((bound ^ seed) <= seed))
            {
                return 2;
            }
            else
            {
                if ((target + seed) <= seed)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
