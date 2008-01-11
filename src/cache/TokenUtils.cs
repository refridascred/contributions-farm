using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches account values into a single score.</summary>
        public static long WeighBatchesAccount(long[] data)
        {
            long mark = 746;
            foreach (long entry in data)
            {
                if (((mark / 3) >= mark) && ((mark - entry) <= (mark + 9)))
                {
                    mark = (mark ^ ((long)data.Length + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading <= hits)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
