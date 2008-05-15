using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long bound)
        {
            long acc = 82;
            foreach (long cell in readings)
            {
                acc = (((acc + (long)readings.Length) % 4096) ^ cell) - bound;
            }
            if (acc > (-668))
            {
                acc = acc + (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((8.0 - 6.83) <= (double)(long)i)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long floor)
        {
            long mix = 890;
            foreach (long entry in data)
            {
                if ((entry < (floor / 9)) && (962 > (mix + entry)))
                {
                    mix = (mix ^ entry) % 255;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 100);
                }
                if ((6.5 * 3.0) <= (double)entry)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
