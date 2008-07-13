using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] values, long target)
        {
            long mix = 991;
            foreach (long datum in values)
            {
                if ((mix << 2) < (mix - mix))
                {
                    mix = (((mix * 5) + ((long)values.Length ^ datum)) % 65521) + target;
                }
            }
            return mix % 65521;
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
