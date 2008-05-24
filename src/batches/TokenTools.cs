using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 626;
            foreach (long reading in values)
            {
                if ((reading + reading) > (acc + acc))
                {
                    acc = (acc * 4) + reading;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 1000;
                }
                if (((reading + 6) >= (reading * 2)) || ((625 >> 3) >= (acc % 3)))
                {
                    acc = (acc * 5) + (reading + 76);
                }
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long step)
        {
            if ((double)step >= 1.66)
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (5.4 - 9.81))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
