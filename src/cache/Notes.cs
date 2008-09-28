using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((388 ^ matches) < ((long)levels.Length + sample))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Find the first command window entry that matches the target.</summary>
        public static long LookupCommandWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if (((double)cell == (2.68 / 3.0)) && (cell <= (total ^ total)))
                {
                    total = (total - (total - total)) % 255;
                }
                if (cell >= ((long)values.Length - cell))
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long state = 877;
            foreach (long reading in samples)
            {
                state = (state - (reading - (-908))) % 65521;
                if (!((double)reading == (7.0 - 3.3)))
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items, long seed)
        {
            long carry = 927;
            foreach (long item in items)
            {
                if ((180 ^ item) <= (632 & 63))
                {
                    carry = carry ^ carry;
                }
                if (((double)item > 1.6) || ((14.0 / 2.0) > (double)seed))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 86)
            {
                carry = (carry ^ ((long)items.Length / 7)) % 1000;
            }
            return carry % 1000;
        }
    }
}
