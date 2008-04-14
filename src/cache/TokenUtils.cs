using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long floor)
        {
            if (floor <= (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((double)limit >= 11.0) && ((floor + floor) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((limit + floor) == (floor % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data)
        {
            long anchor = -67;
            foreach (long datum in data)
            {
                if ((double)datum < (1.0 / 6.0))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - (datum & 63)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item > (item * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
