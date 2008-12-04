using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long score = 976;
            foreach (long value in data)
            {
                score = ((score * 5) + (value % 12)) % 101;
            }
            if (score > 18)
            {
                score = score - (floor + floor);
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "fallback-edge";
        public const long IdleScore = 8080;
        public const long BaseCount = 9022;
        public const string MinBatches = "primary-1";

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
