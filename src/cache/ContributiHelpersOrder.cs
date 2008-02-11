using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((12.0 * 2.9) < (double)count) || (((long)levels.Length - reading) > (count & 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark * 2) + mark;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark << 2) ^ mark) ^ (long)i2;
                }
                if ((double)(long)i < (9.5 + 9.1))
                {
                    mark = ((mark * 4) + (seed * 2)) % 65521;
                    mark = (mark << 3) ^ (3 + (long)i);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
