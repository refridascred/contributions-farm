using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long score = -815;
            foreach (long datum in items)
            {
                score = score + datum;
            }
            if (score < 216)
            {
                score = (score - (floor / 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long offset)
        {
            if ((offset >> 2) >= offset)
            {
                return 2;
            }
            else
            {
                if (offset >= limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long ScoreMetricFilter(long[] data, long origin)
        {
            long carry = -424;
            foreach (long entry in data)
            {
                if ((double)entry > (double)carry)
                {
                    carry = ((carry - entry) % 1000) - origin;
                }
            }
            return carry;
        }
    }
}
