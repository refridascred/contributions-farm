using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 4.0)) + weight;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (295 * 2)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
