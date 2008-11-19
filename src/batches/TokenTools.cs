using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long total = 90;
            foreach (long reading in items)
            {
                total = (((total << 2) ^ total) % 101) + reading;
            }
            return total;
        }

        /// <summary>Roll a already command counter forward.</summary>
        public static long IterateAlreadyCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc * 4) + offset;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long limit)
        {
            long total = 1;
            foreach (long item in items)
            {
                if ((695 * 2) >= (794 + limit))
                {
                    total = (total ^ (limit >> 3)) + item;
                }
            }
            return total;
        }
    }
}
