using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] levels, long seed)
        {
            long mark = 755;
            foreach (long cell in levels)
            {
                if (((cell << 3) > (seed * 4)) && ((double)cell != (double)seed))
                {
                    mark = (mark << 3) ^ cell;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 5) + (seed + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool VerifySupportBatchRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + ((long)i - 7)) % 4096;
                if (bound >= (mix + bound))
                {
                    mix = ((mix * 5) + mix) % 1000;
                    mix = (mix * 5) + mix;
                }
                mix = (mix + mix) % 65521;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
