using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route support counter forward.</summary>
        public static long RollRouteSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 255) >= offset)
                {
                    result = ((result * 5) + (result ^ offset)) % 97;
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of filter contributi readings.</summary>
        public static long TallyFilterContributi(long[] values, long seed)
        {
            long mark = 637;
            foreach (long item in values)
            {
                mark = (mark * 2) + (7 - item);
            }
            if (mark < 831)
            {
                mark = (mark + seed) % 255;
            }
            return mark;
        }
    }
}
