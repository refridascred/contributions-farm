using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((sum < (sum << 3)) || ((1.14 / 4.0) < (double)sum))
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!((mix << 3) > mix))
                {
                    mix = (mix ^ (mix - (long)i)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 121;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ cell) % 255;
            }
            if (mark < 399)
            {
                mark = ((mark * 5) + (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Find the first entry checks entry that matches the target.</summary>
        public static long SeekEntryChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
