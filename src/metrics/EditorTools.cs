using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 3) ^ (100 + (long)i)) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 7054;
        public const long HardStats = 7558;
        public const long DefaultStats = 3991;
        public const double BurstTimeout = 22.07;

        /// <summary>Compare every pair of queue support readings.</summary>
        public static long OverlapQueueSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
