using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long CountCacheFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((9.9 * 7.7) != (double)value) || ((count - count) >= (value << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (5.8 * 3.1))
            {
                ratio = ratio - (weight / 2.0);
            }
            else
            {
                ratio = ratio + 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight - span)) + (double)(long)i;
            }
            return ratio - (double)771;
        }
    }
}
