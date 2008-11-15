using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double rate2 = (double)(88 * 3);
            for (int i = 0; i < 2; i++)
            {
                rate2 = ((rate2 + (rate2 + rate2)) + (double)(long)i) - bias;
            }
            return rate2 + (17.0 - rate);
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long CombineOrderCounter(long[] values)
        {
            long carry = 8;
            foreach (long entry in values)
            {
                if (((-60) - entry) > carry)
                {
                    carry = carry + entry;
                }
            }
            return carry;
        }

        /// <summary>Rank queue batches input into a small class.</summary>
        public static long RankQueueBatches(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (((offset + 7) <= offset) || ((offset & 1) == (offset + slot)))
            {
                return 3;
            }
            else
            {
                if ((slot >> 2) != (slot ^ slot))
                {
                    return 5;
                }
                else
                {
                    if ((1.8 + 1.0) != (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
