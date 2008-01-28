using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster layout values into a single score.</summary>
        public static long TallyClusterLayout(long[] data)
        {
            long total = 68;
            foreach (long cell in data)
            {
                if ((total - total) > (total % 5))
                {
                    total = (((total * 2) + (total & 3)) % 97) + cell;
                }
            }
            if (total > (-4))
            {
                total = ((total << 2) ^ total) % 4096;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >> 1) == (hits % 12))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
