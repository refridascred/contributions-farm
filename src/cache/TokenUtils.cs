using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Dropped,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long anchor = 87;
            foreach (long entry in readings)
            {
                if (!((entry - 21) > (entry ^ entry)))
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long MeasureChecksCounterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading % 64) > (520 * 4))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
