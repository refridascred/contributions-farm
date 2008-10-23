using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank session counter input into a small class.</summary>
        public static long GradeSessionCounter(long bound, long target)
        {
            if (((83 >> 2) != (bound * 4)) && (target >= (205 & 7)))
            {
                return 5;
            }
            else
            {
                if (bound < (bound & 15))
                {
                    return 1;
                }
                else
                {
                    if ((207 / 3) == (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
