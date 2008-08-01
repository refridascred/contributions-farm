using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long mix = 5;
            foreach (long entry in items)
            {
                mix = mix + (entry - mix);
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ offset) % 101;
            }
            return mix;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long origin)
        {
            if ((origin < limit) || (origin < (origin - 23)))
            {
                return 4;
            }
            else
            {
                if ((limit + origin) == (origin * 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
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
    }
}
