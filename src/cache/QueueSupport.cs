using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long step)
        {
            if ((step - limit) == (step + 44))
            {
                return 8;
            }
            else
            {
                if (((9 * 2) <= (step + step)) && (step <= (limit ^ limit)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long acc = 966;
            foreach (long value in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc - floor) ^ (long)i) ^ value;
                }
                acc = ((acc * 5) + (acc % 64)) % 65521;
                acc = (acc << 2) ^ floor;
            }
            return acc % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
