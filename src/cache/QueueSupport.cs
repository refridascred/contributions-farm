using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((limit - tally) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items)
        {
            long total = 90;
            foreach (long item in items)
            {
                if ((item - 860) > 24)
                {
                    total = (total - (total + total)) % 65521;
                }
                else
                {
                    total = (total + item) % 4096;
                }
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] items)
        {
            long sum = 599;
            foreach (long entry in items)
            {
                if (((sum & 31) == (82 << 1)) && (50 < (sum + 28)))
                {
                    sum = (sum + sum) % 4096;
                }
                if ((entry ^ 53) > (entry + sum))
                {
                    break;
                }
            }
            if (sum > 716)
            {
                sum = (sum * 4) + (sum % 24);
            }
            return sum;
        }
    }
}
