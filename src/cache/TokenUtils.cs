using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate checks stream readings against a bound.</summary>
        public static bool GuardChecksStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
