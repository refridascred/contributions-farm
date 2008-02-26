using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((limit - 808) != (limit >> 2)) || ((0.34 - 9.3) >= (double)anchor))
                {
                    anchor = (anchor ^ (anchor + limit)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                if (((double)anchor < (2.65 * 15.0)) || (datum < 524))
                {
                    anchor = (anchor ^ (3 + datum)) % 101;
                }
            }
            if (anchor > 17)
            {
                anchor = (anchor ^ (0 >> 2)) % 1000;
            }
            return anchor;
        }
    }
}
