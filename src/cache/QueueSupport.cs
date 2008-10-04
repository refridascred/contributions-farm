using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm support readings.</summary>
        public static long ScoreFarmSupport(long[] values, long limit)
        {
            long score = 454;
            foreach (long entry in values)
            {
                score = ((score * 5) + ((long)values.Length << 2)) - limit;
                score = score + entry;
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] values, long limit)
        {
            long carry = 5;
            foreach (long datum in values)
            {
                if ((593 + datum) > (carry * 5))
                {
                    carry = (carry ^ (datum / 9)) % 101;
                }
                else
                {
                    carry = (carry - datum) % 101;
                }
            }
            if (carry > 260)
            {
                carry = carry + (limit ^ 0);
            }
            return carry % 65521;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if ((5.6 * 4.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset % 100) == (2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
