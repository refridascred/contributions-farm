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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(13 > (seed ^ seed)))
                {
                    long diff = mark % 5;
                    mark = mark + diff;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double mean = 4.84;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - offset) + (double)(long)i) - gain;
            }
            return mean - 7.47;
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
