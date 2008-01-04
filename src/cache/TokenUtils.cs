using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long TallyBatchesCommitsGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > (639 / 2))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            long gap = seed ^ bound;
            if ((seed / 3) >= (bound + (-65)))
            {
                return 7;
            }
            else
            {
                if ((gap % 7) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (gap <= (seed / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
