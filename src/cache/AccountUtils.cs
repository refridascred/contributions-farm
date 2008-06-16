using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value >> 3) != (56 + value)) || (floor >= (value + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long floor)
        {
            long score = 836;
            foreach (long cell in levels)
            {
                score = ((score ^ (cell - score)) % 255) - floor;
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Paused,
            Retry,
            Failed,
            Dropped,
        }
    }
}
