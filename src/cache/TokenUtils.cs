using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((limit << 1) < 9)
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((12 * 2) >= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support queue entries.</summary>
        public static long CombineSupportQueue(long[] samples)
        {
            long carry = 75;
            foreach (long item in samples)
            {
                carry = ((carry * 5) + (item % 16)) % 255;
            }
            return carry % 97;
        }
    }
}
