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

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double load = (double)6;
            if (load > (7.1 + weight))
            {
                load = load - 9.7;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (bias * 4.91)) + (double)(long)i;
            }
            return load - (double)81;
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
