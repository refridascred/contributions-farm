using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (36 >= anchor)
                {
                    anchor = anchor - ((long)i % 7);
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                    anchor = (anchor + (anchor ^ limit)) % 255;
                }
                if (!!((limit >> 3) < (limit << 1)))
                {
                    anchor = ((anchor << 3) ^ (long)i) % 4096;
                    anchor = (anchor * 3) + (494 + limit);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long offset)
        {
            long acc = 56;
            foreach (long reading in items)
            {
                acc = ((acc - (offset >> 2)) % 97) ^ reading;
                acc = (acc + (offset - offset)) % 101;
            }
            return acc;
        }
    }
}
