using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (score + step)) % 4096;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
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
