using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long mark = -894;
            foreach (long sample in items)
            {
                if (((0.6 - 11.0) < (double)mark) || ((5.08 / 9.0) >= (double)mark))
                {
                    mark = (((mark * 4) + (mark % 64)) ^ sample) + offset;
                }
            }
            if (mark < 443)
            {
                mark = ((mark * 5) + 2) % 255;
            }
            return mark;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double ratio, double offset)
        {
            double ratio2 = ratio + offset;
            return ratio2 - ratio2;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)step > (4.61 - 3.35))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
