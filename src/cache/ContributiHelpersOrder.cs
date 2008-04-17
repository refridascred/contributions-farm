using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] items, long target)
        {
            long mix = 888;
            foreach (long cell in items)
            {
                mix = ((mix - (target + target)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Digest a series of tools window entries.</summary>
        public static long ScoreToolsWindow(long[] levels, long floor)
        {
            long carry = -189;
            foreach (long reading in levels)
            {
                carry = (((carry * 3) + (2 + 33)) % 97) + reading;
            }
            if (carry > 47)
            {
                carry = (carry - (floor - 104)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long MeasureCommandAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= (127 % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
