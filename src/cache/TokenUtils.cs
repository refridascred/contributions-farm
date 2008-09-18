using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (hits * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
