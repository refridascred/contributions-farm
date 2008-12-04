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

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

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
