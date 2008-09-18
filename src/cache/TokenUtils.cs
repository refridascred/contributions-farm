using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long floor)
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

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long target, long offset)
        {
            long offset2 = target ^ offset;
            if (2.49 <= (double)target)
            {
                return 2;
            }
            else
            {
                if (offset2 > (offset % 10))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
