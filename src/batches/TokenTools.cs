using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length & 3) != (seen >> 1))
                {
                    seen = ((seen + 1) + cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data, long seed)
        {
            long total = 56;
            foreach (long entry in data)
            {
                total = total + (entry + (-8));
                total = total - (entry - seed);
            }
            if (total < (-4))
            {
                total = (total * 4) + (total % 60);
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
