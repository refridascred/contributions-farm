using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                if (((2.7 / 9.0) < (double)(long)i) || ((double)(long)i == (5.03 - 8.94)))
                {
                    total = ((total << 3) ^ (target - target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels, long floor)
        {
            long mix = 593;
            foreach (long value in levels)
            {
                mix = (mix + (mix - value)) % 65521;
            }
            if (mix < 5)
            {
                mix = mix + (floor >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry > (8.0 + 6.9)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
