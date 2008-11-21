using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9568;
        public const long DefaultEditor = 6318;
        public const long CacheEditor = 8728;
        public const long RetryEditor = 2392;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long delta = step + bound;
            if (((1.5 - 0.44) >= (double)step) || ((3.5 * 5.7) == (double)bound))
            {
                return 0;
            }
            else
            {
                if ((delta ^ bound) >= (delta / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
