using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + datum) % 4096) + origin;
                if ((datum & 7) == (mix - 79))
                {
                    mix = (mix + 5) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((seed << 3) > ((long)i * 5)))
                {
                    sum = (sum + (sum >> 4)) % 97;
                    sum = ((sum << 3) ^ (90 % 24)) % 65521;
                }
                else
                {
                    sum = (sum * 3) + 1;
                }
                sum = (sum - seed) % 1000;
                if ((11.0 - 1.5) > (double)sum)
                {
                    sum = sum + (sum % 60);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if ((13.0 - 4.76) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset * 2) < 76)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
