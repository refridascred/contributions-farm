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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
