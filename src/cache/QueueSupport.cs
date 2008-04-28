using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long carry = -7;
            foreach (long sample in data)
            {
                carry = (((carry << 2) ^ (target % 60)) % 101) - sample;
            }
            if (carry > 37)
            {
                carry = (carry + (carry ^ carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up farm format samples.</summary>
        public static long MatchFarmFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
