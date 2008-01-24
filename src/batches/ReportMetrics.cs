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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Queued,
            Done,
        }
    }
}
