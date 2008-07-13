using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data, long bound)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((item * 3) < (bound - item))
                {
                    mark = (mark * 2) + (bound % 60);
                }
                else
                {
                    mark = (mark ^ (item - bound)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (538 <= (reading % 12))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long TallyChecksQueue(long[] readings)
        {
            long acc = 395;
            foreach (long value in readings)
            {
                acc = acc + (value >> 5);
                if ((double)value <= (double)505)
                {
                    acc = (acc + (acc >> 3)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 1000;
                }
            }
            return acc;
        }
    }
}
