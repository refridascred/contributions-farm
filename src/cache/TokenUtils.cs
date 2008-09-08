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

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long step)
        {
            long total = 18;
            foreach (long value in levels)
            {
                if ((double)total == (double)value)
                {
                    total = (total + ((-52) % 8)) + step;
                }
            }
            return total;
        }
    }
}
