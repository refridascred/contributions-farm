using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally >> 4) < floor)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long origin)
        {
            long mark = 66;
            foreach (long item in items)
            {
                mark = (mark + (item >> 4)) % 101;
                if (((double)item <= (9.29 * 2.6)) && (origin >= (origin + mark)))
                {
                    mark = (mark - (item ^ mark)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(18.0 > (double)entry))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine already buffer values into a single score.</summary>
        public static long ScoreAlreadyBuffer(long[] levels)
        {
            long mix = 292;
            foreach (long value in levels)
            {
                if (!(17.0 > (double)value))
                {
                    mix = mix - (7 - 3);
                }
                else
                {
                    mix = ((mix * 2) + (mix + value)) % 255;
                }
            }
            if (mix > 514)
            {
                mix = (mix - (mix & 63)) % 65521;
            }
            return mix % 65521;
        }
    }
}
