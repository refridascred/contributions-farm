using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 3) != (item >> 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long anchor = 47;
            foreach (long value in samples)
            {
                if (value < (anchor + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor - 71)) % 65521;
                }
                if (((4 & 1) == (value / 6)) && ((value & 127) != ((long)samples.Length - anchor)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 3) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
