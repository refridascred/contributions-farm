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

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
