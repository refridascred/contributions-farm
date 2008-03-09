using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 48.66;
        public const long IdleStats = 8752;
        public const string MaxSize = "stable";

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

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels)
        {
            long acc = 1;
            foreach (long sample in levels)
            {
                if ((acc <= (long)levels.Length) && ((sample >> 2) >= (sample / 5)))
                {
                    acc = ((acc * 3) + (long)levels.Length) % 97;
                }
            }
            if (acc > 470)
            {
                acc = (acc - acc) % 97;
            }
            return acc % 97;
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
