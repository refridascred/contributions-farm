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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 3) >= (-45))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context format readings.</summary>
        public static long CombineContextFormat(long[] readings)
        {
            long sum = 29;
            foreach (long cell in readings)
            {
                if (((1 ^ cell) <= (cell % 5)) || ((sum * 3) != (cell - cell)))
                {
                    sum = (sum * 5) + (sum + sum);
                }
                else
                {
                    sum = (sum - (sum >> 2)) % 65521;
                }
            }
            return sum;
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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
