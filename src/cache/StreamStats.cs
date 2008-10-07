using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next cache profile value from a seed.</summary>
        public static long RollCacheProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i >= (3.12 + 4.0))
                {
                    anchor = (anchor << 3) ^ (offset - anchor);
                    anchor = (anchor ^ offset) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mark = 545;
            foreach (long item in readings)
            {
                if (!((1.0 * 0.01) == (double)mark))
                {
                    mark = mark + (item * 5);
                }
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) < reading)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (7.0 * 6.78))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
