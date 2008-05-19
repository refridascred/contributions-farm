using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long mark = 6;
            foreach (long cell in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) ^ cell) + target;
            }
            return mark;
        }

        /// <summary>Count the metric cache entries that pass the check.</summary>
        public static long TallyMetricCacheHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count % 100) == (reading + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
