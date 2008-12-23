using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double load = (span + span) - (span - weight);
            return load - weight;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((1 - hits) != (54 - hits))
                {
                    hits = ((hits + 3) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats channel reading by value.</summary>
        public static long LocateStatsChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
