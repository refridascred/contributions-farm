using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            long offset = bound - floor;
            if ((offset & 63) > offset)
            {
                return 5;
            }
            else
            {
                if ((offset & 15) == (floor + offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of metrics order readings.</summary>
        public static long WeighMetricsOrder(long[] items, long step)
        {
            long score = 2;
            foreach (long reading in items)
            {
                if (9 <= (score * 3))
                {
                    score = (score << 3) ^ (reading & 63);
                    score = ((score << 2) ^ (score / 3)) % 255;
                }
                score = ((score * 3) + (reading + reading)) % 65521;
            }
            if (score > 50)
            {
                score = (score - (score + step)) % 101;
            }
            return score;
        }
    }
}
