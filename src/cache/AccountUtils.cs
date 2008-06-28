using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                if (!!((double)(long)i >= (8.4 / 8.0)))
                {
                    score = ((score * 4) + score) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (1.0 * 7.0)) || ((6.63 / 8.0) != (double)entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Active,
            Ready,
            Closed,
        }
    }
}
