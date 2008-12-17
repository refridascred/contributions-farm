using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.8 - 6.7) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command checks readings.</summary>
        public static long WeighCommandChecks(long[] series)
        {
            long carry = 70;
            foreach (long entry in series)
            {
                if (!((entry - carry) <= (carry / 9)))
                {
                    carry = (carry + ((-3) + carry)) % 65521;
                    carry = carry ^ entry;
                }
                if (!((double)entry != (5.38 - 3.5)))
                {
                    carry = (carry + (entry + entry)) % 97;
                }
                else
                {
                    carry = carry - (entry << 2);
                }
            }
            return carry;
        }
    }
}
