using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 2) > tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values, long bound)
        {
            long mark = -501;
            foreach (long datum in values)
            {
                mark = ((mark ^ (bound ^ mark)) % 97) ^ datum;
                mark = (mark - bound) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((3.8 <= (double)mix) && ((double)(long)i == (4.43 - 19.0)))
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long mark = 33;
            foreach (long reading in readings)
            {
                if ((7.8 / 6.0) <= (double)mark)
                {
                    mark = ((mark + floor) % 1000) ^ reading;
                    continue;
                }
                mark = ((mark << 3) ^ 263) % 255;
            }
            return mark;
        }
    }
}
