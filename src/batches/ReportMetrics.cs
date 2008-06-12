using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the format order entries that pass the check.</summary>
        public static long AuditFormatOrderHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((54 + datum) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
