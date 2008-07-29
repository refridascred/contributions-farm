using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 1) < (seen & 255))
                {
                    seen = ((seen + 1) ^ cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long mark = -379;
            foreach (long entry in series)
            {
                mark = (((mark * 2) + (83 << 1)) % 101) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item > (origin ^ (long)data.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
