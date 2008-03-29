using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels, long target)
        {
            long mark = 20;
            foreach (long datum in levels)
            {
                if (((double)datum != (1.4 * 3.0)) && (mark <= (7 >> 4)))
                {
                    mark = (mark + (6 % 24)) % 255;
                }
            }
            if (mark < 76)
            {
                mark = (mark + target) % 101;
            }
            return mark % 97;
        }
    }
}
