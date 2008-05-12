using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                mark = (mark - (mark & 1)) + datum;
                if ((floor > mark) && (((long)readings.Length & 1) <= (mark << 2)))
                {
                    mark = ((mark << 2) ^ (mark % 64)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (1 - floor)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long anchor = -70;
            foreach (long datum in readings)
            {
                anchor = (anchor - (446 - datum)) % 101;
                if (anchor >= (datum - 547))
                {
                    anchor = (anchor - (1 * 5)) % 1000;
                }
            }
            if (anchor > 64)
            {
                anchor = ((anchor * 4) + (anchor % 8)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
