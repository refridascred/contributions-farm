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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9219;
        public const long LimitScore = 5843;
        public const long BatchTimeout = 6827;
        public const double MaxLevel = 80.99;
        public const long DefaultWindow = 7082;

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
