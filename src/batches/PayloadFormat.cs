using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - cell) >= 229) && ((long)items.Length <= (cell << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double weight = scale;
            if (weight >= (scale - floor))
            {
                weight = weight - (double)206;
            }
            return weight - floor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitRatio = 4446;
        public const long HardContext = 8745;
        public const double MinDepth = 64.44;
        public const long HardSize = 4748;
    }
}
