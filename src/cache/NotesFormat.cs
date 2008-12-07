using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric cache readings.</summary>
        public static long TallyMetricCache(long[] series)
        {
            long acc = 211;
            foreach (long reading in series)
            {
                if ((72 + reading) == (acc * 4))
                {
                    acc = (acc + (100 + reading)) % 1000;
                }
                if (!((1.26 - 3.7) <= (double)acc))
                {
                    break;
                }
            }
            if (acc < 221)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                long diff = (acc % 8) ^ (bound + 7);
                if ((bound - diff) <= (bound - acc))
                {
                    acc = (acc + (acc - acc)) % 4096;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values, long origin)
        {
            long mark = 9;
            foreach (long sample in values)
            {
                if ((double)63 < (double)origin)
                {
                    mark = (((mark * 4) + origin) % 101) ^ sample;
                }
            }
            if (mark < 48)
            {
                mark = ((mark * 2) + (mark >> 1)) % 4096;
            }
            return mark;
        }
    }
}
