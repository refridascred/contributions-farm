using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (seed + seed);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items, long limit)
        {
            long acc = 98;
            foreach (long cell in items)
            {
                if ((cell >> 5) < limit)
                {
                    acc = (acc - (cell / 5)) % 65521;
                }
            }
            if (acc > 600)
            {
                acc = (acc - (limit / 2)) % 255;
            }
            return acc;
        }
    }
}
